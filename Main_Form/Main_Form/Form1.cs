using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Form1 : Form
    {

        private FeedList feedlist;
        private RssList<Avsnitt> EpisodeList;
        private KategoriList Kategorier;

        public Form1()
        {
            InitializeComponent();
            feedlist = new FeedList();
            EpisodeList = new RssList<Avsnitt>();
            Kategorier = new KategoriList();
            cboxNyUppdatFrekvens.Items.Add("5");
            cboxNyUppdatFrekvens.Items.Add("10");
            cboxNyUppdatFrekvens.Items.Add("15");
            cboxNyUppdatFrekvens.Items.Add("20");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feedlist = feedlist.Load();
            feedlist.LaggTillEvent();
            feedlist.uppdatera += () => {
                UpdateListOtherThread();
                feedlist.Save(); 
            };
            Kategorier = Kategorier.Load();
            Updatelist();
            UpdateKategorier();
            UppdateraKategoriBox();
            feedlist.changed += SparaOchLaddaLista;
        }

        public void UpdateListOtherThread() {
            if (lvPodcasts.InvokeRequired)
            {
                lvPodcasts.Invoke((MethodInvoker)delegate
                {
                    lvPodcasts.Items.Clear();
                    foreach (var item in feedlist)
                    {
                        var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                        lvPodcasts.Items.Add(itemsToAdd);
                    }
                });
            }
            else {
                lvPodcasts.Items.Clear();
                foreach (var item in feedlist)
                {
                    if (item.Listan == null) {
                        item.Listan = item.ForceList();
                    }
                    var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                    lvPodcasts.Items.Add(itemsToAdd);
                }
                
            }
        }

        public void SparaOchLaddaLista() {
            feedlist.Save();
            Updatelist();
            feedlist.changed += () =>
            {
                SparaOchLaddaLista();
            };
            }

        public void Updatelist()
        {
            lvPodcasts.Items.Clear();
            foreach (var item in feedlist)
            {
                var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                lvPodcasts.Items.Add(itemsToAdd);
            }
          
        }

        public void UpdateKategorier()
        {
            lboxKategori.Items.Clear();
            foreach (var kat in Kategorier)
            {
                lboxKategori.Items.Add(kat.Category);
            }
           
        }
        public void UppdateraKategoriBox() {
            cboxNyKategori.Items.Clear();
            foreach (var k in Kategorier) {
                cboxNyKategori.Items.Add(k.Category);
            }

        }

        private void btnNyPod_Click(object sender, EventArgs e)
        {
            try
            { 
                Validering.KollaOmCbTom(cboxNyKategori);
                Validering.IsEmpty(tbNyUrl.Text);
                Validering.KollaOmCbTom(cboxNyUppdatFrekvens);
                Validering.CheckRssLink(tbNyUrl.Text);
                int frekvens = int.Parse(cboxNyUppdatFrekvens.GetItemText(cboxNyUppdatFrekvens.SelectedItem));
                string category = cboxNyKategori.GetItemText(cboxNyKategori.SelectedItem);
                Feed feed = new Feed(tbNyUrl.Text);
                feed.UppdateringsInterval = frekvens;
                feed.Category = category;
                feedlist.Add(feed);
                feedlist.LaggTillEvent();
                
                feedlist.Save();
                
                Updatelist();

            }
            catch (RssReaderException rss)
            {
                MessageBox.Show(rss.UserMessage);
            }

        }

        private void lvPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPodcasts.SelectedItems.Count > 0)
            {
                int items = lvPodcasts.Items.IndexOf(lvPodcasts.SelectedItems[0]);
                FillEpisodeList(items);
            }
        }

        private void FillEpisodeList(int items)
        {
            lboxAvsnitt.Items.Clear();
            Feed feed = feedlist[items];
            EpisodeList = feed.getListan();
            
                if (EpisodeList != null)
                {
                    foreach (var item in EpisodeList)
                    {
                        lboxAvsnitt.Items.Add(item.Namn);
                    }
                }
                else
                {
                    return;
                }
        }
            
           
            
   

        private void lboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxAvsnitt.SelectedIndex;
            GetDescription(index);
        }

        public void GetDescription(int index)
        {
            Avsnitt avsnitt = EpisodeList[index];
            rtbBeskrivningAvsnitt.Text = avsnitt.Beskrivning.Replace("<p>", "").Replace("</p>", "");
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            try
            {
                Validering.IsEmpty(tbNyKategori.Text);
                Kategori kategori = new Kategori();
                kategori.Category = tbNyKategori.Text;
                Kategorier.Add(kategori);
                lboxKategori.Items.Add(kategori.Category);
                Kategorier.Save();
                UppdateraKategoriBox();
            }
            catch (RssReaderException rss) {
                MessageBox.Show(rss.UserMessage);
            }
            

        }


        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            if (lvPodcasts.SelectedItems.Count > 0)
            {
                int items = lvPodcasts.Items.IndexOf(lvPodcasts.SelectedItems[0]);
                feedlist.RemoveAtIndex(items);

            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if(lboxKategori.SelectedItems.Count > 0)
            {
                int index = lboxKategori.SelectedIndex;
                Kategorier.RemoveAtIndex(index);
            }
            UpdateKategorier();
            Kategorier.Save();
            Kategorier.Load();
            UppdateraKategoriBox();
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedItems.Count > 0)
            {
                string nyKategori = tbNyKategori.Text;
                int index = lboxKategori.SelectedIndex;
                Kategorier[index].Category = nyKategori;

            }
            Kategorier.Save();
            Kategorier.Load();
            UpdateKategorier();
            UppdateraKategoriBox();
        }
    
    }
}

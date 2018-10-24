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
        public Form1()
        {
            InitializeComponent();
            feedlist = new FeedList();
            EpisodeList = new RssList<Avsnitt>();
            cboxNyUppdatFrekvens.Items.Add("Var 5:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 10:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 15:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 20:e minut");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feedlist = feedlist.Load();
            Updatelist();
        }

        public void Updatelist() {
            lvPodcasts.Items.Clear();
            foreach (var item in feedlist)
            {
                var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn  });
                lvPodcasts.Items.Add(itemsToAdd);
            }
        }


        private void btnNyPod_Click(object sender, EventArgs e)
        {
            try {
                Validering.IsEmpty(tbNyUrl.Text);
                Validering.IsEmpty(cboxNyUppdatFrekvens.GetItemText(cboxNyUppdatFrekvens.SelectedItem));
                Feed feed = new Feed(tbNyUrl.Text);
                feedlist.Add(feed);
                feedlist.Save();
                Updatelist();
            }
            catch (ArgumentException ){
                MessageBox.Show("Samtliga alternativ måste vara ifyllda");
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

        private void FillEpisodeList(int items) {
            lboxAvsnitt.Items.Clear();
            Feed feed = feedlist[items];
            EpisodeList = feed.getListan();
            foreach (var item in EpisodeList)
            {
                lboxAvsnitt.Items.Add(item.Namn);
            }
        }

        private void lboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxAvsnitt.SelectedIndex;
            GetDescription(index);
        }

        public void GetDescription(int index) {
            Avsnitt avsnitt = EpisodeList[index];
            rtbBeskrivningAvsnitt.Text = avsnitt.Beskrivning.Replace("<p>", "").Replace("</p>", "");
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {

        }
    }
}

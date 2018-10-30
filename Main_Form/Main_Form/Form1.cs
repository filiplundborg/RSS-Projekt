using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Form1 : Form
    {

        private FeedList FeedList;
        private RssList<Episode> EpisodeList;
        private CategoryList Categories;
        

        public Form1()
        {
            InitializeComponent();
            FeedList = new FeedList();
            EpisodeList = new RssList<Episode>();
            Categories = new CategoryList();
            FillFrequencies();
        }
        private async Task LoadListAsync() {
            await Task.Run(() => {
                FeedList = FeedList.Load();
                FeedList.LaggTillEvent();
                FeedList.changed += SaveAndLoadList;
                FeedList.uppdatera += () => {
                    UpdateListOtherThread();
                };

            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(LoadListAsync);

            Categories = Categories.Load();
            UpdateCategories();
            UpdateCategoryBox();
        }
        private void FillFrequencies() {
            cboxNyUppdatFrekvens.Items.Add("5");
            cboxNyUppdatFrekvens.Items.Add("10");
            cboxNyUppdatFrekvens.Items.Add("15");
            cboxNyUppdatFrekvens.Items.Add("20");
        }

        public void UpdateListOtherThread() {
            if (lvPodcasts.InvokeRequired)
            {
                lvPodcasts.Invoke((MethodInvoker)delegate
                {
                    lvPodcasts.Items.Clear();
                    foreach (var item in FeedList)
                    {
                        if (item.Listan == null)
                        {
                            item.Listan = item.ForceList();
                        }
                        var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                        lvPodcasts.Items.Add(itemsToAdd);
                    }
                });
            }
            else {
                lvPodcasts.Items.Clear();
                foreach (var item in FeedList)
                {
                    if (item.Listan == null) {
                        item.Listan = item.ForceList();
                    }
                    var itemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                    lvPodcasts.Items.Add(itemsToAdd);
                }

            }
        }

        public void SaveAndLoadList() {
            FeedList.Save();
            Updatelist();
            FeedList.changed += () =>
            {
                SaveAndLoadList();
            };
        }

        public void Updatelist()
        {
            lvPodcasts.Items.Clear();
            foreach (var item in FeedList)
            {
                if (item.AntalAvsnitt() == 0) {
                    item.ForceList();
                }

                var ItemsToAdd = new ListViewItem(new[] { item.AntalAvsnitt().ToString(), item.Namn, item.UppdateringsInterval.ToString(), item.Category });
                lvPodcasts.Items.Add(ItemsToAdd);
            }

        }

        public void UpdateCategories()
        {
            lboxKategori.Items.Clear();
            foreach (var kat in Categories)
            {
                lboxKategori.Items.Add(kat.Category);
            }

        }
        public void UpdateCategoryBox() {
            cboxNyKategori.Items.Clear();
            foreach (var k in Categories) {
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
                int Frequency = int.Parse(cboxNyUppdatFrekvens.GetItemText(cboxNyUppdatFrekvens.SelectedItem));
                string category = cboxNyKategori.GetItemText(cboxNyKategori.SelectedItem);
                Feed feed = new Feed(tbNyUrl.Text);
                feed.UppdateringsInterval = Frequency;
                feed.Category = category;
                FeedList.Add(feed);
                FeedList.LaggTillEvent();

                FeedList.Save();

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
            Feed feed = FeedList[items];
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
            Episode avsnitt = EpisodeList[index];
            rtbBeskrivningAvsnitt.Text = avsnitt.Beskrivning.Replace("<p>", "").Replace("</p>", "");
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            try
            {
                Validering.IsEmpty(tbNyKategori.Text);
                Kategori kategori = new Kategori();
                kategori.Category = tbNyKategori.Text;
                Categories.Add(kategori);
                lboxKategori.Items.Add(kategori.Category);
                Categories.Save();
                UpdateCategoryBox();
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
                FeedList.RemoveAtIndex(items);

            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedItems.Count > 0)
            {
                int index = lboxKategori.SelectedIndex;
                Categories.RemoveAtIndex(index);

            }
            UpdateCategories();
            Categories.Save();
            Categories.Load();
            UpdateCategoryBox();
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedItems.Count > 0)
            {
                string NewCategory = tbNyKategori.Text;
                int index = lboxKategori.SelectedIndex;
                Categories[index].Category = NewCategory;

            }
            Categories.Save();
            Categories.Load();
            UpdateCategories();
            UpdateCategoryBox();
        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            if (lvPodcasts.SelectedItems.Count > 0) {
                int index = lvPodcasts.Items.IndexOf(lvPodcasts.SelectedItems[0]);
                var ChangedCategory = ComboBoxToString(cboxNyKategori);
                var ChangedInterval = ComboBoxToString(cboxNyUppdatFrekvens);
                var NewUrl = tbNyUrl.Text;

                if(ChangedCategory != "")
                {
                    FeedList[index].Category = ChangedCategory;
                }

                if(ChangedInterval != "")
                {
                    FeedList[index].UppdateringsInterval = int.Parse(ChangedInterval);
                }

                if(NewUrl != "")
                {
                    try
                    {
                        Validering.CheckRssLink(NewUrl);
                        FeedList[index].Url = NewUrl;
                        FeedList[index].ForceList();
                        FeedList[index].ForceNamn();
                    }
                    catch(RssReaderException ex) {
                        MessageBox.Show(ex.UserMessage);
                    }
                }
                
                
            }
            Updatelist();
            FeedList.Save();
        }
        private string ComboBoxToString(ComboBox boxen) {
            return boxen.GetItemText(boxen.SelectedItem);
        }

        private void lboxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxKategori.SelectedIndex;
            if (index != -1)
            {
                FeedList = FeedList.SortList(Categories[index]) as FeedList;
                FeedList.LaggTillEvent();
                FeedList.changed += SaveAndLoadList;
                Updatelist();
            }
            else
            {
                return;
            }
        }
    }

}

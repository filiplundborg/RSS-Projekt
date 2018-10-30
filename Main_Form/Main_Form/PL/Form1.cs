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
                FeedList.AddTimerEvent();
                FeedList.ListChanged += SaveAndLoadList;
                FeedList.TimerElapsed += () => {
                    UpdateListOtherThread();
                };

            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(LoadListAsync);
            CategoryActionsLoad();
        }

        private void CategoryActionsLoad() {
            Categories = Categories.Load();
            UpdateCategories();
            UpdateCategoryBox();
        }
        private void CategoryActionsSave()
        {
            Categories.Save();
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
                        ForceEpisodeList(item);
                        var itemsToAdd = new ListViewItem(new[] { item.AmountOfEpisodes().ToString(), item.Name, item.UpdatingInterval.ToString(), item.TheCategory });
                        lvPodcasts.Items.Add(itemsToAdd);
                    }
                });
            }
            else {
                lvPodcasts.Items.Clear();
                foreach (var item in FeedList)
                {
                    ForceEpisodeList(item);
                    var itemsToAdd = new ListViewItem(new[] { item.AmountOfEpisodes().ToString(), item.Name, item.UpdatingInterval.ToString(), item.TheCategory });
                    lvPodcasts.Items.Add(itemsToAdd);
                }

            }
        }
        private void ForceEpisodeList(Feed item) {
            if (item.TheList == null || item.AmountOfEpisodes() == 0)
            {
                item.TheList = item.ForceList();
            }
        }

        public void SaveAndLoadList() {
            FeedListActions();
            FeedList.ListChanged += () =>
            {
                SaveAndLoadList();
            };
        }

        private void FeedListActions()
        {
            FeedList.Save();
            Updatelist();
        }

        public void Updatelist()
        {
            lvPodcasts.Items.Clear();
            foreach (var item in FeedList)
            {
                ForceEpisodeList(item);
                var ItemsToAdd = new ListViewItem(new[] { item.AmountOfEpisodes().ToString(), item.Name, item.UpdatingInterval.ToString(), item.TheCategory });
                lvPodcasts.Items.Add(ItemsToAdd);
            }
        }

        public void UpdateCategories()
        {
            lboxKategori.Items.Clear();
            foreach (var kat in Categories)
            {
                lboxKategori.Items.Add(kat.TheCategory);
            }

        }
        public void UpdateCategoryBox() {
            cboxNyKategori.Items.Clear();
            foreach (var k in Categories) {
                cboxNyKategori.Items.Add(k.TheCategory);
            }
        }

        private void btnNyPod_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Form.Validate.CheckIfCbEmpty(cboxNyKategori);
                Main_Form.Validate.IsEmpty(tbNyUrl.Text);
                Main_Form.Validate.CheckIfCbEmpty(cboxNyUppdatFrekvens);
                Main_Form.Validate.CheckRssLink(tbNyUrl.Text);
                int Frequency = int.Parse(cboxNyUppdatFrekvens.GetItemText(cboxNyUppdatFrekvens.SelectedItem));
                string category = cboxNyKategori.GetItemText(cboxNyKategori.SelectedItem);
                Feed feed = new Feed(tbNyUrl.Text);
                feed.UpdatingInterval = Frequency;
                feed.TheCategory = category;
                FeedList.Add(feed);
                FeedList.AddTimerEvent();
                FeedListActions();
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
            EpisodeList = feed.GetTheList();
            if (EpisodeList != null)
            {
                foreach (var item in EpisodeList)
                {
                    lboxAvsnitt.Items.Add(item.Name);
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
            rtbBeskrivningAvsnitt.Text = avsnitt.Description.Replace("<p>", "").Replace("</p>", "");
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Form.Validate.IsEmpty(tbNyKategori.Text);
                Category kategori = new Category();
                kategori.TheCategory = tbNyKategori.Text;
                Categories.Add(kategori);
                lboxKategori.Items.Add(kategori.TheCategory);
                CategoryActionsSave();
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
            CategoryActionsSave();
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            if (lboxKategori.SelectedItems.Count > 0)
            {
                string NewCategory = tbNyKategori.Text;
                int index = lboxKategori.SelectedIndex;
                Categories[index].TheCategory = NewCategory;

            }
            CategoryActionsSave();
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
                    FeedList[index].TheCategory = ChangedCategory;
                }

                if(ChangedInterval != "")
                {
                    FeedList[index].UpdatingInterval = int.Parse(ChangedInterval);
                }

                if(NewUrl != "")
                {
                    try
                    {
                        Main_Form.Validate.CheckRssLink(NewUrl);
                        FeedList[index].Url = NewUrl;
                        FeedList[index].ForceList();
                        FeedList[index].ForceName();
                    }
                    catch(RssReaderException ex) {
                        MessageBox.Show(ex.UserMessage);
                    }
                }
            }
            FeedListActions();
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
                FeedList.AddTimerEvent();
                FeedList.ListChanged += SaveAndLoadList;
                Updatelist();
            }
            else
            {
                return;
            }
        }
    }

}

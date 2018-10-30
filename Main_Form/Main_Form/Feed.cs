using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main_Form
{
    public class Feed : Category
    {
        
        public string Url { get; set; }
        public string Name { get; set; }
        public int UpdatingInterval { get; set; }
        public Category Category { get; set; }
        public RssList<Episode> TheList { get; set; }
        public delegate void UpdateHandler();
        public event UpdateHandler FeedChanged;


        public Feed(string url) {

            this.TheList = new RssList<Episode>();
            this.Url = url;
            this.Name = RSSDataBaseHandling.GetName(Url);
            SetTimer();
        }

        public Feed() {
            SetTimer();
        }

        
        public RssList<Episode> GetTheList() {
            return this.TheList;
        }

        public int AmountOfEpisodes() => TheList != null ? TheList.Count : 0;

        public RssList<Episode> ForceList() {
            TheList = RSSDataBaseHandling.GetAvsnitt(Url);
            return TheList;
        }

        public string ForceName()
        {
            Name = RSSDataBaseHandling.GetName(Url);
            return Name;
        }
        

        public void SetTimer()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    TheList = RSSDataBaseHandling.GetAvsnitt(Url);
                    FeedChanged();
                    await Task.Delay(UpdatingInterval*60000);
                }
            });
        }

        
    }
    }


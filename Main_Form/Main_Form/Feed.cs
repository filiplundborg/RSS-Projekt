using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main_Form
{
    public class Feed : Kategori
    {
        
        public string Url { get; set; }
        public string Namn { get; set; }
        public int UppdateringsInterval { get; set; }
        public Kategori Kategorin { get; set; }
        public RssList<Episode> Listan { get; set; }
        public delegate void UppdateringsHanterare();
        public event UppdateringsHanterare andrad;


        public Feed(string url) {

            this.Listan = new RssList<Episode>();
            this.Url = url;
            this.Namn = RSSDataBaseHandling.GetName(Url);
            setTimer();
        }

        public Feed() {
            setTimer();
        }

        
        public RssList<Episode> getListan() {
            return this.Listan;
        }

        public int AntalAvsnitt() => Listan != null ? Listan.Count : 0;

        public RssList<Episode> ForceList() {
            Listan = RSSDataBaseHandling.GetAvsnitt(Url);
            return Listan;
        }

        public string ForceNamn()
        {
            Namn = RSSDataBaseHandling.GetName(Url);
            return Namn;
        }
        

        public void setTimer()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    Listan = RSSDataBaseHandling.GetAvsnitt(Url);
                    andrad();
                    await Task.Delay(UppdateringsInterval*60000);
                }
            });
        }

        
    }
    }


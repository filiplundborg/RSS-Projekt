using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main_Form
{
    public class Feed : Kategori, ISortable<Feed>
    {
        public string Url { get; set; }
        public string Namn { get; set; }
        public int UppdateringsInterval { get; set; }
        public Kategori Kategorin { get; set; }
        public RssList<Avsnitt> Listan { get; set; }
        public delegate void UppdateringsHanterare();
        public event UppdateringsHanterare andrad;


        public Feed(string url) {

            this.Listan = new RssList<Avsnitt>();
            this.Url = url;
            this.Namn = RSSDataBaseHandling.GetName(Url);
            Listan = RSSDataBaseHandling.GetAvsnitt(Url);
            setTimer();
        }

        public Feed() {
            setTimer();
        }

        public object Sort(object categori)
        {
            Kategori kategori = categori as Kategori;

            if (this.Category == kategori.Category)
            {
                return this;
            }
            else {
                return null;
            }

        }
        public RssList<Avsnitt> getListan() {
            return this.Listan;
        }

        public int AntalAvsnitt() => Listan != null ? Listan.Count : 0;

        public RssList<Avsnitt> ForceList() {
            Listan = RSSDataBaseHandling.GetAvsnitt(Url);
            return Listan;
        }
        
        
                
            
           
        

        public Feed Sort(Feed obj)
        {
            throw new NotImplementedException();
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


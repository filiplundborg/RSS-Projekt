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
        public string UppdateringsInterval { get; set; }
        public Kategori Kategorin { get; set; }
        public Frekvens Frekvensen { get; set; }
        public RssList<Avsnitt> Listan { get; set; }
        

        public Feed(string url) {
            this.Listan = new RssList<Avsnitt>();
            this.Url = url;
            this.Namn = RSSDataBaseHandling.GetName(Url);
            Listan = RSSDataBaseHandling.GetAvsnitt(Url);
        }

        public Feed() { }

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

        public int AntalAvsnitt()
        { int antal = 0;

            for (int i = 0; i < Listan.Count; i++) {
                antal++;
            }
            return antal;
        }

        public Feed Sort(Feed obj)
        {
            throw new NotImplementedException();
        }
    }
}

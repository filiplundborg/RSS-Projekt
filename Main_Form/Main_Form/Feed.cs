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
        

        public Feed() {
            this.Listan = new RssList<Avsnitt>();
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
    }
}

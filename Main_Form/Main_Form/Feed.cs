using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
            Timer timer;
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
        { 
            
                int antal = 0;
                for (int i = 0; i < Listan.Count; i++)
                {
                    antal++;
                }
                return antal;
            
           
        }

        public Feed Sort(Feed obj)
        {
            throw new NotImplementedException();
        }

        public void setIntervall() {           
            switch (Frekvensen) {
                case Frekvens.fiveMinutes:
                     var timer1 = new Timer();
                    timer1.Interval = 300000;
                    break;
                case Frekvens.tenMinutes:
                    var timer2 = new Timer();
                    timer2.Interval = 600000;
                    break;
                case Frekvens.fifteenMinutes:
                    var timer3 = new Timer();
                    timer3.Interval = 900000;
                    break;
                case Frekvens.twentyMinutes:
                    var timer4 = new Timer();
                    timer4.Interval = 12000000;
                    break;

            } 
        }
    }
}

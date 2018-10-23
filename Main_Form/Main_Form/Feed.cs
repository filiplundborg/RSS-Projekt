using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    class Feed
    {
        public string Url { get; set; }
        public string Namn { get; set; }
        public string UppdateringsInterval { get; set; }
        public Kategori Kategorin { get; set; }
        public Frekvens Frekvensen { get; set; }
        public RssList<Episodes> Listan { get; set; }

        public Feed() {
            this.Listan = new RssList<Episodes>;
        }
    }
}

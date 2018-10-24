using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class Avsnitt : ISortable<Avsnitt>
    {
        public string Namn { get; set; }
        public string Beskrivning { get; set; }

        public Avsnitt Sort(Avsnitt obj)
        {
            throw new NotImplementedException();
        }
    }
}

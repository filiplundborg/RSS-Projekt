using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class KategoriList : List<Kategori>
    {
        public void Save()
        {
            KategoriDatabaseHandling.Serialize(this);
        }

        public KategoriList Load()
        {
           return KategoriDatabaseHandling.Deserialize();
        }
        public void RemoveAtIndex(int index)
        {
            this.RemoveAt(index);
            
        }
    }
}

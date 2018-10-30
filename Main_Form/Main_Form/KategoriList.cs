using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class CategoryList : List<Category>, ISaveAndLoadable<CategoryList>
    {
        public void Save()
        {
            KategoriDatabaseHandling.Serialize(this);
        }

        public CategoryList Load()
        {
           return KategoriDatabaseHandling.Deserialize();
        }
        public void RemoveAtIndex(int index)
        {
            this.RemoveAt(index);
            
        }
    }
}

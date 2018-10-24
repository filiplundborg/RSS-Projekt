using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class RssList<T> : List<T> where T: ISortable<T>
    {
        public List<T> Sort(T obj)
        {
            List<T> list = new List<T>();
            foreach (var item in this) {
                T ob = item.Sort(obj);
                if (ob != null) {
                    list.Add(ob);
                }
            }
            return list;
        }

        
    }
}

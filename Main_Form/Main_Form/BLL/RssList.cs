
using System.Collections.Generic;
using System.Linq;


namespace Main_Form
{
    public class RssList<T> : List<T> where T: class
    {
        public virtual RssList<T> SortList(object obj)
        {
            RssList<T> t = new RssList<T>();
            var list = t.OrderBy((item) => item).ToList();
            foreach (var item in list) {
                t.Add(item);
            }
            return t;
        }
        
        
    }
}

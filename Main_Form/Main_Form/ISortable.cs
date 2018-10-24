using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public interface ISortable<T>
    {
        T Sort(T obj);
    }
}

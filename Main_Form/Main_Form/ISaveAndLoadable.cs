using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    interface ISaveAndLoadable<T>
    {
        void Save();
        T Load();
    }
}

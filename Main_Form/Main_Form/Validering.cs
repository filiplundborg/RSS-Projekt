using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public static class Validering
    {
        public static bool IsEmpty(string toCheck)
        {
            if(toCheck == "")
            {
                throw new ArgumentException();
               
            }
            else
            {
                return true;
                   
            }
        }
    }
}

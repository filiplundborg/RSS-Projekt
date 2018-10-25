using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static bool KollaOmCbTom(ComboBox attKolla)
        {
            if (attKolla.GetItemText(attKolla.SelectedItem).Length > 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }
}

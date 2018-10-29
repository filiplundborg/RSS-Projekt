﻿using System;
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
                throw new RssReaderException("Fälten får inte vara tomma");
               
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
                throw new RssReaderException("Ett alternativ måste väljas");
            }

        }

        public static bool CheckRssLink(string url) {
            string title = RSSDataBaseHandling.GetName(url);
            if (title != null) {
                return true;
            }
            else
            {
                throw new RssReaderException("Kan inte hitta någon data." + "\n" + "Kontrollera den angivna länken.");
            }
            
            
        }

        
    }
}

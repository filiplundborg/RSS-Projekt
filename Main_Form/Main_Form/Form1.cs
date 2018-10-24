using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Form1 : Form
    {
        private FeedList feedlist;
        public Form1()
        {
            InitializeComponent();
            feedlist = new FeedList();
            cboxNyUppdatFrekvens.Items.Add("Var 5:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 10:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 15:e minut");
            cboxNyUppdatFrekvens.Items.Add("Var 20:e minut");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //feedlist = feedlist.Load();
        }

        private void btnNyPod_Click(object sender, EventArgs e)
        {
            try {
                Validering.IsEmpty(tbNyUrl.Text);
                Validering.IsEmpty(cboxNyUppdatFrekvens.GetItemText(cboxNyUppdatFrekvens.SelectedItem));
                Feed feed = new Feed(tbNyUrl.Text);
                feedlist.Add(feed);
                feedlist.Save();
            }
            catch (ArgumentException ){
                MessageBox.Show("Samtliga alternativ måste vara ifyllda");
            }
            
        }
    }
}

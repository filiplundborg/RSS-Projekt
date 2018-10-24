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
        private KategoriList kategorier;
        public Form1()
        {
            InitializeComponent();
            feedlist = new FeedList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feedlist = feedlist.Load();
        }

        private void btnNyPod_Click(object sender, EventArgs e)
        {
            Feed feed = new Feed(tbNyUrl.Text);
            feedlist.Add(feed);
            feedlist.Save();
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Category = tbNyKategori.Text;
            lboxKategori.Items.Add(kategori.Category);

            
            kategorier.Add(kategori);

        }
    }
}

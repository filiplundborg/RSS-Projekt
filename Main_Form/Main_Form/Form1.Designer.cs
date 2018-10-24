namespace Main_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbNyUrl = new System.Windows.Forms.TextBox();
            this.cboxNyKategori = new System.Windows.Forms.ComboBox();
            this.cboxNyUppdatFrekvens = new System.Windows.Forms.ComboBox();
            this.btnNyPod = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.columnAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboxKategori = new System.Windows.Forms.ListBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.tbNyKategori = new System.Windows.Forms.TextBox();
            this.lboxAvsnitt = new System.Windows.Forms.ListBox();
            this.rtbBeskrivningAvsnitt = new System.Windows.Forms.RichTextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUppdatFrekvens = new System.Windows.Forms.Label();
            this.lblKategoriFeed = new System.Windows.Forms.Label();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblAvsnittBeskrivning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAvsnitt,
            this.columnNamn,
            this.columnFrekvens,
            this.columnKategori});
            this.listView1.Location = new System.Drawing.Point(37, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tbNyUrl
            // 
            this.tbNyUrl.Location = new System.Drawing.Point(37, 431);
            this.tbNyUrl.Name = "tbNyUrl";
            this.tbNyUrl.Size = new System.Drawing.Size(184, 26);
            this.tbNyUrl.TabIndex = 1;
            // 
            // cboxNyKategori
            // 
            this.cboxNyKategori.FormattingEnabled = true;
            this.cboxNyKategori.Location = new System.Drawing.Point(482, 429);
            this.cboxNyKategori.Name = "cboxNyKategori";
            this.cboxNyKategori.Size = new System.Drawing.Size(121, 28);
            this.cboxNyKategori.TabIndex = 2;
            // 
            // cboxNyUppdatFrekvens
            // 
            this.cboxNyUppdatFrekvens.FormattingEnabled = true;
            this.cboxNyUppdatFrekvens.Location = new System.Drawing.Point(272, 429);
            this.cboxNyUppdatFrekvens.Name = "cboxNyUppdatFrekvens";
            this.cboxNyUppdatFrekvens.Size = new System.Drawing.Size(181, 28);
            this.cboxNyUppdatFrekvens.TabIndex = 3;
            // 
            // btnNyPod
            // 
            this.btnNyPod.Location = new System.Drawing.Point(263, 475);
            this.btnNyPod.Name = "btnNyPod";
            this.btnNyPod.Size = new System.Drawing.Size(89, 34);
            this.btnNyPod.TabIndex = 4;
            this.btnNyPod.Text = "Ny...";
            this.btnNyPod.UseVisualStyleBackColor = true;
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(373, 475);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(89, 34);
            this.btnSparaPodcast.TabIndex = 5;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(491, 475);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(112, 34);
            this.btnTaBortPodcast.TabIndex = 6;
            this.btnTaBortPodcast.Text = "Ta bort...";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            // 
            // columnAvsnitt
            // 
            this.columnAvsnitt.Text = "Avsnitt";
            // 
            // columnNamn
            // 
            this.columnNamn.Text = "Namn";
            this.columnNamn.Width = 100;
            // 
            // columnFrekvens
            // 
            this.columnFrekvens.Text = "Frekvens";
            this.columnFrekvens.Width = 100;
            // 
            // columnKategori
            // 
            this.columnKategori.Text = "Kategori";
            this.columnKategori.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(875, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 7;
            // 
            // lboxKategori
            // 
            this.lboxKategori.FormattingEnabled = true;
            this.lboxKategori.ItemHeight = 20;
            this.lboxKategori.Location = new System.Drawing.Point(702, 37);
            this.lboxKategori.Name = "lboxKategori";
            this.lboxKategori.Size = new System.Drawing.Size(451, 344);
            this.lboxKategori.TabIndex = 8;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(721, 475);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(92, 34);
            this.btnNyKategori.TabIndex = 9;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(875, 475);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(109, 34);
            this.btnSparaKategori.TabIndex = 10;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1037, 475);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(98, 34);
            this.btnTaBortKategori.TabIndex = 11;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // tbNyKategori
            // 
            this.tbNyKategori.Location = new System.Drawing.Point(770, 420);
            this.tbNyKategori.Name = "tbNyKategori";
            this.tbNyKategori.Size = new System.Drawing.Size(324, 26);
            this.tbNyKategori.TabIndex = 12;
            // 
            // lboxAvsnitt
            // 
            this.lboxAvsnitt.FormattingEnabled = true;
            this.lboxAvsnitt.ItemHeight = 20;
            this.lboxAvsnitt.Location = new System.Drawing.Point(37, 559);
            this.lboxAvsnitt.Name = "lboxAvsnitt";
            this.lboxAvsnitt.Size = new System.Drawing.Size(566, 304);
            this.lboxAvsnitt.TabIndex = 13;
            // 
            // rtbBeskrivningAvsnitt
            // 
            this.rtbBeskrivningAvsnitt.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.rtbBeskrivningAvsnitt.Location = new System.Drawing.Point(702, 559);
            this.rtbBeskrivningAvsnitt.Name = "rtbBeskrivningAvsnitt";
            this.rtbBeskrivningAvsnitt.ReadOnly = true;
            this.rtbBeskrivningAvsnitt.Size = new System.Drawing.Size(451, 304);
            this.rtbBeskrivningAvsnitt.TabIndex = 14;
            this.rtbBeskrivningAvsnitt.Text = "";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(45, 397);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(45, 20);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            // 
            // lblUppdatFrekvens
            // 
            this.lblUppdatFrekvens.AutoSize = true;
            this.lblUppdatFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdatFrekvens.Location = new System.Drawing.Point(268, 397);
            this.lblUppdatFrekvens.Name = "lblUppdatFrekvens";
            this.lblUppdatFrekvens.Size = new System.Drawing.Size(185, 20);
            this.lblUppdatFrekvens.TabIndex = 16;
            this.lblUppdatFrekvens.Text = "Uppdateringsfrekvens";
            // 
            // lblKategoriFeed
            // 
            this.lblKategoriFeed.AutoSize = true;
            this.lblKategoriFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriFeed.Location = new System.Drawing.Point(508, 397);
            this.lblKategoriFeed.Name = "lblKategoriFeed";
            this.lblKategoriFeed.Size = new System.Drawing.Size(76, 20);
            this.lblKategoriFeed.TabIndex = 17;
            this.lblKategoriFeed.Text = "Kategori";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(698, 14);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(92, 20);
            this.lblKategorier.TabIndex = 18;
            this.lblKategorier.Text = "Kategorier";
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyKategori.Location = new System.Drawing.Point(883, 397);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(101, 20);
            this.lblNyKategori.TabIndex = 19;
            this.lblNyKategori.Text = "Ny Kategori";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(185, 536);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(223, 20);
            this.lblAvsnitt.TabIndex = 20;
            this.lblAvsnitt.Text = "Här ska det genereras info";
            // 
            // lblAvsnittBeskrivning
            // 
            this.lblAvsnittBeskrivning.AutoSize = true;
            this.lblAvsnittBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittBeskrivning.Location = new System.Drawing.Point(803, 536);
            this.lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            this.lblAvsnittBeskrivning.Size = new System.Drawing.Size(275, 20);
            this.lblAvsnittBeskrivning.TabIndex = 21;
            this.lblAvsnittBeskrivning.Text = "Här ska det också genereras info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1220, 928);
            this.Controls.Add(this.lblAvsnittBeskrivning);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblKategoriFeed);
            this.Controls.Add(this.lblUppdatFrekvens);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.rtbBeskrivningAvsnitt);
            this.Controls.Add(this.lboxAvsnitt);
            this.Controls.Add(this.tbNyKategori);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.lboxKategori);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnNyPod);
            this.Controls.Add(this.cboxNyUppdatFrekvens);
            this.Controls.Add(this.cboxNyKategori);
            this.Controls.Add(this.tbNyUrl);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.Text = "Den mäktiga podcastappen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnAvsnitt;
        private System.Windows.Forms.TextBox tbNyUrl;
        private System.Windows.Forms.ComboBox cboxNyKategori;
        private System.Windows.Forms.ComboBox cboxNyUppdatFrekvens;
        private System.Windows.Forms.Button btnNyPod;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.ColumnHeader columnNamn;
        private System.Windows.Forms.ColumnHeader columnFrekvens;
        private System.Windows.Forms.ColumnHeader columnKategori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lboxKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.TextBox tbNyKategori;
        private System.Windows.Forms.ListBox lboxAvsnitt;
        private System.Windows.Forms.RichTextBox rtbBeskrivningAvsnitt;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUppdatFrekvens;
        private System.Windows.Forms.Label lblKategoriFeed;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblAvsnittBeskrivning;
    }
}


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
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.columnAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNyUrl = new System.Windows.Forms.TextBox();
            this.cboxNyKategori = new System.Windows.Forms.ComboBox();
            this.cboxNyUppdatFrekvens = new System.Windows.Forms.ComboBox();
            this.btnNyPod = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
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
            // lvPodcasts
            // 
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAvsnitt,
            this.columnNamn,
            this.columnFrekvens,
            this.columnKategori});
            this.lvPodcasts.FullRowSelect = true;
            this.lvPodcasts.Location = new System.Drawing.Point(33, 30);
            this.lvPodcasts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(504, 281);
            this.lvPodcasts.TabIndex = 0;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            this.lvPodcasts.View = System.Windows.Forms.View.Details;
            this.lvPodcasts.SelectedIndexChanged += new System.EventHandler(this.lvPodcasts_SelectedIndexChanged);
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
            // tbNyUrl
            // 
            this.tbNyUrl.Location = new System.Drawing.Point(33, 345);
            this.tbNyUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNyUrl.Name = "tbNyUrl";
            this.tbNyUrl.Size = new System.Drawing.Size(164, 22);
            this.tbNyUrl.TabIndex = 1;
            // 
            // cboxNyKategori
            // 
            this.cboxNyKategori.FormattingEnabled = true;
            this.cboxNyKategori.Location = new System.Drawing.Point(428, 343);
            this.cboxNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxNyKategori.Name = "cboxNyKategori";
            this.cboxNyKategori.Size = new System.Drawing.Size(108, 24);
            this.cboxNyKategori.TabIndex = 2;
            // 
            // cboxNyUppdatFrekvens
            // 
            this.cboxNyUppdatFrekvens.FormattingEnabled = true;
            this.cboxNyUppdatFrekvens.Location = new System.Drawing.Point(242, 343);
            this.cboxNyUppdatFrekvens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxNyUppdatFrekvens.Name = "cboxNyUppdatFrekvens";
            this.cboxNyUppdatFrekvens.Size = new System.Drawing.Size(161, 24);
            this.cboxNyUppdatFrekvens.TabIndex = 3;
            // 
            // btnNyPod
            // 
            this.btnNyPod.Location = new System.Drawing.Point(201, 380);
            this.btnNyPod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNyPod.Name = "btnNyPod";
            this.btnNyPod.Size = new System.Drawing.Size(79, 27);
            this.btnNyPod.TabIndex = 4;
            this.btnNyPod.Text = "Ny...";
            this.btnNyPod.UseVisualStyleBackColor = true;
            this.btnNyPod.Click += new System.EventHandler(this.btnNyPod_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(332, 380);
            this.btnSparaPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(79, 27);
            this.btnSparaPodcast.TabIndex = 5;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(436, 380);
            this.btnTaBortPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(100, 27);
            this.btnTaBortPodcast.TabIndex = 6;
            this.btnTaBortPodcast.Text = "Ta bort...";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(778, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 6);
            this.panel1.TabIndex = 7;
            // 
            // lboxKategori
            // 
            this.lboxKategori.FormattingEnabled = true;
            this.lboxKategori.ItemHeight = 16;
            this.lboxKategori.Location = new System.Drawing.Point(624, 30);
            this.lboxKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxKategori.Name = "lboxKategori";
            this.lboxKategori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lboxKategori.Size = new System.Drawing.Size(401, 276);
            this.lboxKategori.TabIndex = 8;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(641, 380);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(82, 27);
            this.btnNyKategori.TabIndex = 9;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(778, 380);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(97, 27);
            this.btnSparaKategori.TabIndex = 10;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(922, 380);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(87, 27);
            this.btnTaBortKategori.TabIndex = 11;
            this.btnTaBortKategori.Text = "Ta bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // tbNyKategori
            // 
            this.tbNyKategori.Location = new System.Drawing.Point(684, 336);
            this.tbNyKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNyKategori.Name = "tbNyKategori";
            this.tbNyKategori.Size = new System.Drawing.Size(288, 22);
            this.tbNyKategori.TabIndex = 12;
            // 
            // lboxAvsnitt
            // 
            this.lboxAvsnitt.FormattingEnabled = true;
            this.lboxAvsnitt.ItemHeight = 16;
            this.lboxAvsnitt.Location = new System.Drawing.Point(33, 447);
            this.lboxAvsnitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxAvsnitt.Name = "lboxAvsnitt";
            this.lboxAvsnitt.Size = new System.Drawing.Size(504, 244);
            this.lboxAvsnitt.TabIndex = 13;
            this.lboxAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lboxAvsnitt_SelectedIndexChanged);
            // 
            // rtbBeskrivningAvsnitt
            // 
            this.rtbBeskrivningAvsnitt.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.rtbBeskrivningAvsnitt.Location = new System.Drawing.Point(624, 447);
            this.rtbBeskrivningAvsnitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbBeskrivningAvsnitt.Name = "rtbBeskrivningAvsnitt";
            this.rtbBeskrivningAvsnitt.ReadOnly = true;
            this.rtbBeskrivningAvsnitt.Size = new System.Drawing.Size(401, 244);
            this.rtbBeskrivningAvsnitt.TabIndex = 14;
            this.rtbBeskrivningAvsnitt.Text = "";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(40, 318);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(39, 17);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            // 
            // lblUppdatFrekvens
            // 
            this.lblUppdatFrekvens.AutoSize = true;
            this.lblUppdatFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdatFrekvens.Location = new System.Drawing.Point(238, 318);
            this.lblUppdatFrekvens.Name = "lblUppdatFrekvens";
            this.lblUppdatFrekvens.Size = new System.Drawing.Size(167, 17);
            this.lblUppdatFrekvens.TabIndex = 16;
            this.lblUppdatFrekvens.Text = "Uppdateringsfrekvens";
            // 
            // lblKategoriFeed
            // 
            this.lblKategoriFeed.AutoSize = true;
            this.lblKategoriFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriFeed.Location = new System.Drawing.Point(452, 318);
            this.lblKategoriFeed.Name = "lblKategoriFeed";
            this.lblKategoriFeed.Size = new System.Drawing.Size(69, 17);
            this.lblKategoriFeed.TabIndex = 17;
            this.lblKategoriFeed.Text = "Kategori";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(620, 11);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(84, 17);
            this.lblKategorier.TabIndex = 18;
            this.lblKategorier.Text = "Kategorier";
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyKategori.Location = new System.Drawing.Point(785, 318);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(93, 17);
            this.lblNyKategori.TabIndex = 19;
            this.lblNyKategori.Text = "Ny Kategori";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(164, 429);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(203, 17);
            this.lblAvsnitt.TabIndex = 20;
            this.lblAvsnitt.Text = "Här ska det genereras info";
            // 
            // lblAvsnittBeskrivning
            // 
            this.lblAvsnittBeskrivning.AutoSize = true;
            this.lblAvsnittBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittBeskrivning.Location = new System.Drawing.Point(714, 429);
            this.lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            this.lblAvsnittBeskrivning.Size = new System.Drawing.Size(250, 17);
            this.lblAvsnittBeskrivning.TabIndex = 21;
            this.lblAvsnittBeskrivning.Text = "Här ska det också genereras info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 742);
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
            this.Controls.Add(this.lvPodcasts);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 28);
            this.Text = "Den mäktiga podcastappen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcasts;
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


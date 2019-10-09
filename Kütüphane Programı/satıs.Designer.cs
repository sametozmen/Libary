namespace Kütüphane_Programı
{
    partial class satıs
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
            this.components = new System.ComponentModel.Container();
            this.lstsatıs = new System.Windows.Forms.ListView();
            this.barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatıldı = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.nmtutar = new System.Windows.Forms.NumericUpDown();
            this.btnclr = new System.Windows.Forms.Button();
            this.nmadet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrbrkd = new System.Windows.Forms.Timer(this.components);
            this.tmrnm = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbcikis = new System.Windows.Forms.PictureBox();
            this.pcbgeri = new System.Windows.Forms.PictureBox();
            this.tmrsaat = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arkaplanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrfk = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmtutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmadet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstsatıs
            // 
            this.lstsatıs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.barkod,
            this.ad,
            this.stok,
            this.fiyat,
            this.miktar});
            this.lstsatıs.ContextMenuStrip = this.contextMenuStrip1;
            this.lstsatıs.GridLines = true;
            this.lstsatıs.Location = new System.Drawing.Point(39, 56);
            this.lstsatıs.Name = "lstsatıs";
            this.lstsatıs.Size = new System.Drawing.Size(527, 163);
            this.lstsatıs.TabIndex = 0;
            this.lstsatıs.UseCompatibleStateImageBehavior = false;
            this.lstsatıs.View = System.Windows.Forms.View.Details;
            // 
            // barkod
            // 
            this.barkod.Text = "Barkod";
            this.barkod.Width = 127;
            // 
            // ad
            // 
            this.ad.Text = "Kitap Adı";
            this.ad.Width = 157;
            // 
            // stok
            // 
            this.stok.Text = "StokAdet";
            this.stok.Width = 70;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Fiyat";
            this.fiyat.Width = 109;
            // 
            // miktar
            // 
            this.miktar.Text = "Miktar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.yazıRengiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.carpi1;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.font;
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(168, 15);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(182, 22);
            this.txtbarkod.TabIndex = 0;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(321, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tutar :";
            // 
            // btnSatıldı
            // 
            this.btnSatıldı.BackColor = System.Drawing.Color.White;
            this.btnSatıldı.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSatıldı.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSatıldı.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSatıldı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatıldı.ForeColor = System.Drawing.Color.Black;
            this.btnSatıldı.Location = new System.Drawing.Point(572, 170);
            this.btnSatıldı.Name = "btnSatıldı";
            this.btnSatıldı.Size = new System.Drawing.Size(107, 49);
            this.btnSatıldı.TabIndex = 4;
            this.btnSatıldı.Text = "ALIŞVERİŞİ ONAYLA";
            this.btnSatıldı.UseVisualStyleBackColor = false;
            this.btnSatıldı.Click += new System.EventHandler(this.btnSatıldı_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.White;
            this.btnİptal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnİptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.ForeColor = System.Drawing.Color.Black;
            this.btnİptal.Location = new System.Drawing.Point(572, 113);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(107, 51);
            this.btnİptal.TabIndex = 3;
            this.btnİptal.Text = "Günlük Cirolar";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // nmtutar
            // 
            this.nmtutar.BackColor = System.Drawing.Color.White;
            this.nmtutar.DecimalPlaces = 2;
            this.nmtutar.Enabled = false;
            this.nmtutar.Location = new System.Drawing.Point(407, 229);
            this.nmtutar.Name = "nmtutar";
            this.nmtutar.Size = new System.Drawing.Size(120, 22);
            this.nmtutar.TabIndex = 48;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.White;
            this.btnclr.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnclr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclr.ForeColor = System.Drawing.Color.Black;
            this.btnclr.Location = new System.Drawing.Point(572, 56);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(107, 49);
            this.btnclr.TabIndex = 49;
            this.btnclr.Text = "Listeyi Temizle";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // nmadet
            // 
            this.nmadet.Enabled = false;
            this.nmadet.Location = new System.Drawing.Point(192, 230);
            this.nmadet.Name = "nmadet";
            this.nmadet.Size = new System.Drawing.Size(102, 22);
            this.nmadet.TabIndex = 1;
            this.nmadet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmadet.ValueChanged += new System.EventHandler(this.nmadet_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Adet Giriniz : ";
            // 
            // tmrbrkd
            // 
            this.tmrbrkd.Tick += new System.EventHandler(this.tmrbrkd_Tick);
            // 
            // tmrnm
            // 
            this.tmrnm.Tick += new System.EventHandler(this.tmrnm_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkod :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtbarkod);
            this.groupBox1.Controls.Add(this.pcbcikis);
            this.groupBox1.Controls.Add(this.pcbgeri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmtutar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmadet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnclr);
            this.groupBox1.Controls.Add(this.btnİptal);
            this.groupBox1.Controls.Add(this.btnSatıldı);
            this.groupBox1.Controls.Add(this.lstsatıs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 271);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(534, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(514, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "TL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(509, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 33);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // pcbcikis
            // 
            this.pcbcikis.BackColor = System.Drawing.Color.Transparent;
            this.pcbcikis.Image = global::Kütüphane_Programı.Properties.Resources.Battle_exit_icon;
            this.pcbcikis.Location = new System.Drawing.Point(659, 13);
            this.pcbcikis.Name = "pcbcikis";
            this.pcbcikis.Size = new System.Drawing.Size(35, 27);
            this.pcbcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcikis.TabIndex = 46;
            this.pcbcikis.TabStop = false;
            this.pcbcikis.Click += new System.EventHandler(this.pcbcikis_Click);
            // 
            // pcbgeri
            // 
            this.pcbgeri.Image = global::Kütüphane_Programı.Properties.Resources.ssss;
            this.pcbgeri.Location = new System.Drawing.Point(618, 15);
            this.pcbgeri.Name = "pcbgeri";
            this.pcbgeri.Size = new System.Drawing.Size(35, 25);
            this.pcbgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbgeri.TabIndex = 53;
            this.pcbgeri.TabStop = false;
            this.pcbgeri.Click += new System.EventHandler(this.pcbgeri_Click);
            // 
            // tmrsaat
            // 
            this.tmrsaat.Tick += new System.EventHandler(this.tmrsaat_Tick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaplanRengiToolStripMenuItem,
            this.yazıTipiToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.dilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(193, 92);
            // 
            // arkaplanRengiToolStripMenuItem
            // 
            this.arkaplanRengiToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.arkaplanRengiToolStripMenuItem.Name = "arkaplanRengiToolStripMenuItem";
            this.arkaplanRengiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.arkaplanRengiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            this.arkaplanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaplanRengiToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem1
            // 
            this.yazıTipiToolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.font;
            this.yazıTipiToolStripMenuItem1.Name = "yazıTipiToolStripMenuItem1";
            this.yazıTipiToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.yazıTipiToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.yazıTipiToolStripMenuItem1.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem1.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "Yazı Rengi";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.dilToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.indir__1_;
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            this.dilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.dilToolStripMenuItem.Text = "Dil";
            // 
            // türkçeToolStripMenuItem
            // 
            this.türkçeToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.Flag_of_Turkey_svg;
            this.türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            this.türkçeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.türkçeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.türkçeToolStripMenuItem.Text = "Türkçe";
            this.türkçeToolStripMenuItem.Click += new System.EventHandler(this.türkçeToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.indir;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // tmrfk
            // 
            this.tmrfk.Interval = 35;
            this.tmrfk.Tick += new System.EventHandler(this.tmrfk_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(356, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 20);
            this.linkLabel1.TabIndex = 64;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.sivrilerbilisim.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // satıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(739, 294);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satıs";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satıs";
            this.Load += new System.EventHandler(this.satıs_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmtutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmadet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstsatıs;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSatıldı;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ColumnHeader barkod;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader stok;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader miktar;
        private System.Windows.Forms.PictureBox pcbcikis;
        private System.Windows.Forms.NumericUpDown nmtutar;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.NumericUpDown nmadet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrbrkd;
        private System.Windows.Forms.PictureBox pcbgeri;
        private System.Windows.Forms.Timer tmrnm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrsaat;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer tmrfk;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
namespace Kütüphane_Programı
{
    partial class SatılanÜrünler
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
            this.pcbgeri = new System.Windows.Forms.PictureBox();
            this.pcbcikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtarih = new System.Windows.Forms.ComboBox();
            this.lskkayıtlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tmrsaat = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arkaplanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englisgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrefkt = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbgeri
            // 
            this.pcbgeri.Image = global::Kütüphane_Programı.Properties.Resources.ssss;
            this.pcbgeri.Location = new System.Drawing.Point(611, 16);
            this.pcbgeri.Name = "pcbgeri";
            this.pcbgeri.Size = new System.Drawing.Size(35, 25);
            this.pcbgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbgeri.TabIndex = 54;
            this.pcbgeri.TabStop = false;
            this.pcbgeri.Click += new System.EventHandler(this.pcbgeri_Click);
            // 
            // pcbcikis
            // 
            this.pcbcikis.BackColor = System.Drawing.Color.Transparent;
            this.pcbcikis.Image = global::Kütüphane_Programı.Properties.Resources.Battle_exit_icon;
            this.pcbcikis.Location = new System.Drawing.Point(659, 16);
            this.pcbcikis.Name = "pcbcikis";
            this.pcbcikis.Size = new System.Drawing.Size(35, 27);
            this.pcbcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcikis.TabIndex = 55;
            this.pcbcikis.TabStop = false;
            this.pcbcikis.Click += new System.EventHandler(this.pcbcikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tarih Seçimini Yapınız :";
            // 
            // cmbtarih
            // 
            this.cmbtarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtarih.FormattingEnabled = true;
            this.cmbtarih.Location = new System.Drawing.Point(179, 20);
            this.cmbtarih.Name = "cmbtarih";
            this.cmbtarih.Size = new System.Drawing.Size(121, 21);
            this.cmbtarih.TabIndex = 57;
            this.cmbtarih.SelectedIndexChanged += new System.EventHandler(this.cmbtarih_SelectedIndexChanged);
            // 
            // lskkayıtlar
            // 
            this.lskkayıtlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lskkayıtlar.GridLines = true;
            this.lskkayıtlar.Location = new System.Drawing.Point(29, 63);
            this.lskkayıtlar.Name = "lskkayıtlar";
            this.lskkayıtlar.Size = new System.Drawing.Size(674, 237);
            this.lskkayıtlar.TabIndex = 58;
            this.lskkayıtlar.UseCompatibleStateImageBehavior = false;
            this.lskkayıtlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkod";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KitapAdı";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SatılanAdet";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ToplamFiyat";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Saat";
            this.columnHeader7.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "label2";
            // 
            // tmrsaat
            // 
            this.tmrsaat.Tick += new System.EventHandler(this.tmrsaat_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Kazanılan Toplam Para :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(454, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(526, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "TL";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaplanRengiToolStripMenuItem,
            this.yazıTipiToolStripMenuItem1,
            this.yazıRengiToolStripMenuItem1,
            this.dilToolStripMenuItem1});
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
            // yazıRengiToolStripMenuItem1
            // 
            this.yazıRengiToolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.yazıRengiToolStripMenuItem1.Name = "yazıRengiToolStripMenuItem1";
            this.yazıRengiToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.yazıRengiToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.yazıRengiToolStripMenuItem1.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem1.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem1_Click);
            // 
            // dilToolStripMenuItem1
            // 
            this.dilToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem1,
            this.englisgToolStripMenuItem});
            this.dilToolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.indir__1_;
            this.dilToolStripMenuItem1.Name = "dilToolStripMenuItem1";
            this.dilToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.dilToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.dilToolStripMenuItem1.Text = "Dil";
            // 
            // türkçeToolStripMenuItem1
            // 
            this.türkçeToolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.Flag_of_Turkey_svg;
            this.türkçeToolStripMenuItem1.Name = "türkçeToolStripMenuItem1";
            this.türkçeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.türkçeToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.türkçeToolStripMenuItem1.Text = "Türkçe";
            this.türkçeToolStripMenuItem1.Click += new System.EventHandler(this.türkçeToolStripMenuItem1_Click);
            // 
            // englisgToolStripMenuItem
            // 
            this.englisgToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.indir;
            this.englisgToolStripMenuItem.Name = "englisgToolStripMenuItem";
            this.englisgToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.englisgToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.englisgToolStripMenuItem.Text = "English";
            this.englisgToolStripMenuItem.Click += new System.EventHandler(this.englisgToolStripMenuItem_Click);
            // 
            // tmrefkt
            // 
            this.tmrefkt.Interval = 35;
            this.tmrefkt.Tick += new System.EventHandler(this.tmrefkt_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(317, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 20);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.sivrilerbilisim.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SatılanÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(708, 325);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lskkayıtlar);
            this.Controls.Add(this.cmbtarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbcikis);
            this.Controls.Add(this.pcbgeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatılanÜrünler";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatılanÜrünler";
            this.Load += new System.EventHandler(this.SatılanÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbgeri;
        private System.Windows.Forms.PictureBox pcbcikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtarih;
        private System.Windows.Forms.ListView lskkayıtlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrsaat;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englisgToolStripMenuItem;
        private System.Windows.Forms.Timer tmrefkt;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
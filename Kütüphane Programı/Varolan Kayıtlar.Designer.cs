namespace Kütüphane_Programı
{
    partial class Varolan_Kayıtlar
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
            this.lskkayıtlar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtyynv = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfyt = new System.Windows.Forms.TextBox();
            this.CMBTÜR = new System.Windows.Forms.ComboBox();
            this.btnsts = new System.Windows.Forms.Button();
            this.cmbarma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aranankelime = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrsaat = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arkaplanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbgeri = new System.Windows.Forms.PictureBox();
            this.pcbcikis = new System.Windows.Forms.PictureBox();
            this.ekfttmr = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).BeginInit();
            this.SuspendLayout();
            // 
            // lskkayıtlar
            // 
            this.lskkayıtlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lskkayıtlar.ContextMenuStrip = this.contextMenuStrip1;
            this.lskkayıtlar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lskkayıtlar.GridLines = true;
            this.lskkayıtlar.Location = new System.Drawing.Point(12, 120);
            this.lskkayıtlar.Name = "lskkayıtlar";
            this.lskkayıtlar.Size = new System.Drawing.Size(433, 230);
            this.lskkayıtlar.TabIndex = 9;
            this.lskkayıtlar.UseCompatibleStateImageBehavior = false;
            this.lskkayıtlar.View = System.Windows.Forms.View.Details;
            this.lskkayıtlar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barkod";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 54;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "StokAdet";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KitapAdı";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yayınevi";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tür";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.yazıRengiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.güncelle;
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.carpi;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Barkod :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fiyat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kitap Adı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tür : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Yayınevi : ";
            // 
            // txtyynv
            // 
            this.txtyynv.Location = new System.Drawing.Point(161, 267);
            this.txtyynv.Name = "txtyynv";
            this.txtyynv.Size = new System.Drawing.Size(155, 22);
            this.txtyynv.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(161, 210);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(155, 22);
            this.txtad.TabIndex = 6;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(161, 63);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(155, 22);
            this.txtbarkod.TabIndex = 3;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsil.Location = new System.Drawing.Point(331, 271);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(80, 60);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil ";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.White;
            this.btngüncelle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btngüncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngüncelle.Location = new System.Drawing.Point(331, 68);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(80, 60);
            this.btngüncelle.TabIndex = 9;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Stok Adet : ";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(161, 154);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(155, 22);
            this.txtstok.TabIndex = 5;
            this.txtstok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstok_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfyt);
            this.groupBox1.Controls.Add(this.CMBTÜR);
            this.groupBox1.Controls.Add(this.btnsts);
            this.groupBox1.Controls.Add(this.txtstok);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.txtbarkod);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtyynv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(503, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 393);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYITLARI DÜZENLE";
            // 
            // txtfyt
            // 
            this.txtfyt.Location = new System.Drawing.Point(161, 108);
            this.txtfyt.Name = "txtfyt";
            this.txtfyt.Size = new System.Drawing.Size(155, 22);
            this.txtfyt.TabIndex = 4;
            // 
            // CMBTÜR
            // 
            this.CMBTÜR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTÜR.FormattingEnabled = true;
            this.CMBTÜR.Items.AddRange(new object[] {
            "Konu Anlatımı",
            "Soru Bankası",
            "Yaprak Test",
            "Deneme",
            "Fasikül",
            "Roman",
            "Hikaye",
            "Masal",
            "Şiir",
            "Çocuk Kitabı"});
            this.CMBTÜR.Location = new System.Drawing.Point(161, 315);
            this.CMBTÜR.Name = "CMBTÜR";
            this.CMBTÜR.Size = new System.Drawing.Size(157, 24);
            this.CMBTÜR.TabIndex = 8;
            // 
            // btnsts
            // 
            this.btnsts.BackColor = System.Drawing.Color.White;
            this.btnsts.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnsts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsts.Location = new System.Drawing.Point(331, 162);
            this.btnsts.Name = "btnsts";
            this.btnsts.Size = new System.Drawing.Size(80, 60);
            this.btnsts.TabIndex = 10;
            this.btnsts.Text = "Hızlı Satış";
            this.btnsts.UseVisualStyleBackColor = false;
            this.btnsts.Click += new System.EventHandler(this.btnsts_Click);
            // 
            // cmbarma
            // 
            this.cmbarma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbarma.FormattingEnabled = true;
            this.cmbarma.Items.AddRange(new object[] {
            "Barkod",
            "Fiyat",
            "StokAdet",
            "KitapAdı",
            "Yayınevi",
            "Tür"});
            this.cmbarma.Location = new System.Drawing.Point(254, 74);
            this.cmbarma.Name = "cmbarma";
            this.cmbarma.Size = new System.Drawing.Size(183, 21);
            this.cmbarma.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hangi Satırda Aramak İstersiniz : ";
            // 
            // aranankelime
            // 
            this.aranankelime.Location = new System.Drawing.Point(255, 30);
            this.aranankelime.Name = "aranankelime";
            this.aranankelime.Size = new System.Drawing.Size(183, 22);
            this.aranankelime.TabIndex = 1;
            this.aranankelime.Text = "";
            this.aranankelime.TextChanged += new System.EventHandler(this.aranankelime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Aranacak Kelimeyi Giriniz  : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tüm Kayıtları Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(363, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "label4";
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
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 92);
            // 
            // arkaplanRengiToolStripMenuItem
            // 
            this.arkaplanRengiToolStripMenuItem.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.arkaplanRengiToolStripMenuItem.Name = "arkaplanRengiToolStripMenuItem";
            this.arkaplanRengiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.arkaplanRengiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            this.arkaplanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaplanRengiToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem1
            // 
            this.yazıTipiToolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.font;
            this.yazıTipiToolStripMenuItem1.Name = "yazıTipiToolStripMenuItem1";
            this.yazıTipiToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.yazıTipiToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.yazıTipiToolStripMenuItem1.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem1.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Kütüphane_Programı.Properties.Resources.renk;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
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
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
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
            // pcbgeri
            // 
            this.pcbgeri.Image = global::Kütüphane_Programı.Properties.Resources.ssss;
            this.pcbgeri.Location = new System.Drawing.Point(442, 44);
            this.pcbgeri.Name = "pcbgeri";
            this.pcbgeri.Size = new System.Drawing.Size(26, 25);
            this.pcbgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbgeri.TabIndex = 52;
            this.pcbgeri.TabStop = false;
            this.pcbgeri.Click += new System.EventHandler(this.pcbgeri_Click);
            // 
            // pcbcikis
            // 
            this.pcbcikis.BackColor = System.Drawing.Color.Transparent;
            this.pcbcikis.Image = global::Kütüphane_Programı.Properties.Resources.Battle_exit_icon;
            this.pcbcikis.Location = new System.Drawing.Point(443, 8);
            this.pcbcikis.Name = "pcbcikis";
            this.pcbcikis.Size = new System.Drawing.Size(28, 27);
            this.pcbcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcikis.TabIndex = 3;
            this.pcbcikis.TabStop = false;
            this.pcbcikis.Click += new System.EventHandler(this.pcbcikis_Click);
            // 
            // ekfttmr
            // 
            this.ekfttmr.Interval = 35;
            this.ekfttmr.Tick += new System.EventHandler(this.ekfttmr_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(272, 97);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 20);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.sivrilerbilisim.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Varolan_Kayıtlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(485, 413);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcbgeri);
            this.Controls.Add(this.cmbarma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lskkayıtlar);
            this.Controls.Add(this.aranankelime);
            this.Controls.Add(this.pcbcikis);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Varolan_Kayıtlar";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Varolan_Kayıtlar";
            this.Load += new System.EventHandler(this.Varolan_Kayıtlar_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbcikis;
        private System.Windows.Forms.ListView lskkayıtlar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtyynv;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbarma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox aranankelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbgeri;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrsaat;
        private System.Windows.Forms.ComboBox CMBTÜR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.TextBox txtfyt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer ekfttmr;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
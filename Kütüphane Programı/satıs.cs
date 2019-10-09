using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Programı
{
    public partial class satıs : Form
    {
        public satıs()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphanem.accdb;Persist Security Info=False");
        OleDbCommand cmd2 = new OleDbCommand();
        public void ING()
        {
            Class1.secim = "İngilizce";
            label3.Left = 10;
            label1.Text = "Barcode :";
            label2.Text = "Price :";
            label3.Text = "Enter The Pieces :";
            btnclr.Text = "Clear List";
            btnİptal.Text = "Daily Turnover";
            btnSatıldı.Text = "Confirm The Sale";
            groupBox1.Text = "Sales";
            lstsatıs.Columns.Clear();
            lstsatıs.Columns.Add("Barcode", 134, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("BookName", 174, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Stock", 70, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Price", 79, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Quantity", 66, HorizontalAlignment.Left);
            yazıTipiToolStripMenuItem1.Text = "Font";
            arkaplanRengiToolStripMenuItem.Text = "Backcolor";
            dilToolStripMenuItem.Text = "Language";
            silToolStripMenuItem.Text = "Delete";
            yazıTipiToolStripMenuItem.Text = "Font";
            yazıRengiToolStripMenuItem.Text = "Backgroundcolor";
        }
        public void Turkce()
        {
            label3.Left = 37;
            Class1.secim = "Türkçe";
            lstsatıs.Columns.Clear();
            label1.Text = "Barkod :";
            label2.Text = "Tutar :";
            label3.Text = "Adet Giriniz :";
            btnclr.Text = "Listeyi Temizle";
            btnİptal.Text = "Günlük Cirolar";
            btnSatıldı.Text = "Alışverişi Onayla";
            groupBox1.Text = "Satış";
            lstsatıs.Columns.Add("Barkod", 134, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("KitapAdı", 174, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Stok", 70, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Fiyat", 79, HorizontalAlignment.Left);
            lstsatıs.Columns.Add("Miktar", 66, HorizontalAlignment.Left);
            yazıTipiToolStripMenuItem1.Text = "Yazı Tipi";
            arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            dilToolStripMenuItem.Text = "Dil";
            silToolStripMenuItem.Text = "Sil";
            yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
        }
        public void aramayap()
        {
            bool durum = true;
            for (int i = 0; i < lstsatıs.Items.Count; i++)
            {
                if (lstsatıs.Items[i].SubItems[0].Text == txtbarkod.Text.Trim())
                {
                    try
                    {
                        durum = false;
                        int count = int.Parse(lstsatıs.Items[i].SubItems[4].Text);
                        count++;
                        lstsatıs.Items[i].SubItems[4].Text = count.ToString();
                        break;
                    }
                    catch (Exception)
                    {}
              }
            }
            cmd2.Connection = cnn;
            OleDbDataReader verioku = cmd2.ExecuteReader();
            if (durum)
            {
                while (verioku.Read())
                {
                    ListViewItem item = lstsatıs.Items.Add(verioku["Barkod"].ToString());
                    item.SubItems.Add(verioku["KitapAdı"].ToString());
                    item.SubItems.Add(verioku["StokAdet"].ToString());
                    item.SubItems.Add(verioku["Fiyat"].ToString());
                    item.SubItems.Add(Convert.ToString(1));
                }
            }
            cmd2.Dispose();
           }
        private void KayitlariGoster()
        {
            int sayac = 0;
            lstsatıs.Items.Clear();
            cnn.Close();
            cnn.Open();
            cmd2.CommandText = "SELECT * FROM kütüphane";
            cmd2.Connection = cnn;
            OleDbDataAdapter dap = new OleDbDataAdapter(cmd2);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            sayac = dt.Rows.Count;
            for (int i = 0; i < sayac; i++)
            {
                lstsatıs.Items.Add(dt.Rows[i]["Barkod"].ToString());

                lstsatıs.Items[i].SubItems.Add(dt.Rows[i]["KitapAdı"].ToString());
                lstsatıs.Items[i].SubItems.Add(dt.Rows[i]["StokAdet"].ToString());
                lstsatıs.Items[i].SubItems.Add(dt.Rows[i]["Fiyat"].ToString());
            }
           }
        public double TutarBul()
        {
            double tutar = 0;
            for (int i = 0; i < this.lstsatıs.Items.Count; i++)
            {
                try
                {
                    tutar += double.Parse(this.lstsatıs.Items[i].SubItems[3].Text) * double.Parse(this.lstsatıs.Items[i].SubItems[4].Text);
                }
                catch (Exception)
                {}
             }
            return tutar;
        }
        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
                tmr = 0;
                tmrbrkd.Start();
                cnn.Close();
                cnn.Open();
                cmd2.CommandText = "Select * From kütüphane Where Barkod = '" + txtbarkod.Text.Trim() + "'";
                cmd2.Connection = cnn;
                aramayap();
                this.nmtutar.Text = this.TutarBul().ToString();
                if (this.lstsatıs.Items.Count!=0)
            {
                for (int i = 0; i < this.lstsatıs.Items.Count; i++)
                {
                    try
                    {
                        int stok = int.Parse(lstsatıs.Items[i].SubItems[2].Text);
                        int miktar = int.Parse(lstsatıs.Items[i].SubItems[4].Text);
                        if (miktar > stok)
                        {
                            lstsatıs.Items[i].SubItems[4].Text = stok.ToString();
                            if (groupBox1.Text == "Satış") MessageBox.Show("Stoktaki Miktardan Fazla Okutamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("You Will not be able to Stock More Product Sales", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (miktar < 0)
                        {
                            lstsatıs.Items[i].SubItems[4].Text = "0";
                        }
                    }
                    catch (Exception)
                    {}
               }
            }
         }
        private void pcbcikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            if (label1.Text=="Barkod :")
            {
                cikis = MessageBox.Show("Çıkmak İstediğinden Emin Misin ?", "Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else cikis = MessageBox.Show("Are You Sure You Want to Exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
        private void btnSatıldı_Click(object sender, EventArgs e)
        {
            nmadet.Value = 0;
            try
            {
                if (cnn.State.ToString() == "Closed") cnn.Open();
                int miktar = Convert.ToInt32(lstsatıs.Items[0].SubItems[4].Text);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE kütüphane SET StokAdet=StokAdet-" + miktar + " Where Barkod='" + lstsatıs.Items[0].SubItems[0].Text + "'";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                if (label1.Text == "Barkod :") MessageBox.Show("Satış Başarıyla Gerçekleşti.", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else MessageBox.Show("The sales took place Successfully.", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            catch (Exception)
            {
                if (Class1.secim == "Türkçe") MessageBox.Show("Öncelikle Satılacak Ürünleri Belirlemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("First, determine the products to be sold", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            for (int i = 0; i < lstsatıs.Items.Count; i++)
            {
                if (cnn.State.ToString() == "Closed") cnn.Open();
                OleDbCommand cmd3 = new OleDbCommand("Insert Into satislar(Barkod,KitapAdı,SatılanAdet,Fiyatı,ToplamFiyat,Saat,Tarih) Values('" + lstsatıs.Items[i].SubItems[0].Text + "','" + lstsatıs.Items[i].SubItems[1].Text + "','" + lstsatıs.Items[i].SubItems[4].Text + "','" + lstsatıs.Items[i].SubItems[3].Text + "','" + nmtutar.Value.ToString() + "','" + DateTime.Now.ToLongTimeString() + "','" + DateTime.Now.ToShortDateString() + "')");
                cmd3.Connection = cnn;
                cmd3.ExecuteNonQuery();
            }
            lstsatıs.Items.Clear();
       }
        public int ıptal = 0,sayı=0;
        private void btnİptal_Click(object sender, EventArgs e)
        {
            SatılanÜrünler stln = new SatılanÜrünler();
            stln.Show();
            this.Hide();
        }
      private void satıs_Load(object sender, EventArgs e)
        {
            tmrfk.Start();
            if (Class1.secim == "İngilizce")ING();
            else Turkce();
            tmrsaat.Start();
            nmtutar.Maximum = int.MaxValue;
         }
        private void btnclr_Click(object sender, EventArgs e)
        {
            tmrnm.Stop();
            lstsatıs.Items.Clear();
            nmadet.Value = 1;
        }
         public int tmr = 0;
        private void tmrbrkd_Tick(object sender, EventArgs e)
        {
            tmr++;
            if (tmr>8)
            {
                txtbarkod.Clear();
                tmrbrkd.Stop();
            }
        }
       private void pcbgeri_Click(object sender, EventArgs e)
        {
            Anaform afm = new Anaform();
            afm.Show();
            this.Hide();
        }
            private void tmrnm_Tick(object sender, EventArgs e)
        {
           
            try
            {
                lstsatıs.FocusedItem.SubItems[4].Text = nmadet.Value.ToString();
            }
            catch (Exception)
            {
                tmrnm.Stop();
            }
        }
         private void nmadet_ValueChanged(object sender, EventArgs e)
        {
            if (lstsatıs.Items.Count == 0)
            {
                tmrnm.Stop();
                if (label1.Text == "Barkod :") MessageBox.Show("Lütfen Bir Kayıt Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Please Select a Record In The", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lstsatıs.Items.Count!=0) tmrnm.Start();
            TutarBul();
            this.nmtutar.Text = this.TutarBul().ToString();
            int stk = 0;
            stk = Convert.ToInt32(nmadet.Value);
            try
            {
                if (stk > Convert.ToInt32(lstsatıs.FocusedItem.SubItems[2].Text))nmadet.Value = Convert.ToInt32(lstsatıs.FocusedItem.SubItems[2].Text);
            }
            catch (Exception)
            {
            if (groupBox1.Text == "Satış"&&lstsatıs.Items.Count>0) MessageBox.Show("Bu Kadar Stokta Ürün Bulunmamaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (groupBox1.Text != "Satış") MessageBox.Show("You Will not be able to Stock More Product Sales", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (groupBox1.Text == "Satış") MessageBox.Show("Lütfen Bir Kayıt Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Please Select a Record In The", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstsatıs.FocusedItem.Remove();
        }
        private void tmrsaat_Tick(object sender, EventArgs e)
        {
            TutarBul();
            this.nmtutar.Text = this.TutarBul().ToString();
            if (lstsatıs.Items.Count > 0) nmadet.Enabled = true;
            else nmadet.Enabled = false;
            label6.Text = DateTime.Now.ToLongTimeString();
        }
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lstsatıs.Font = fontDialog1.Font;
        }
        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lstsatıs.ForeColor = colorDialog1.Color;
        }
        private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color; label6.BackColor = colorDialog1.Color;
        }
        private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font; label2.Font = fontDialog1.Font; label3.Font = fontDialog1.Font;
            label4.Font = fontDialog1.Font; label6.Font = fontDialog1.Font;
        }
        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turkce();
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ING();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
            label2.ForeColor = colorDialog1.Color;
            label3.ForeColor = colorDialog1.Color;
            label4.ForeColor = colorDialog1.Color;
            label6.ForeColor = colorDialog1.Color;
            btnclr.ForeColor = colorDialog1.Color;
            btnİptal.ForeColor = colorDialog1.Color;
            btnSatıldı.ForeColor = colorDialog1.Color;
        }

        private void tmrfk_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100) this.Opacity = this.Opacity + 5 * 0.01;
            else tmrfk.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sivrilerbilisim.com/");

        }
     }
}

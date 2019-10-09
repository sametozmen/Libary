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
    public partial class Varolan_Kayıtlar : Form
    {
        public Varolan_Kayıtlar()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphanem.accdb;Persist Security Info=False");
        public void trk()
        {
            Class1.secim = "Türkçe";
            label1.Text = "Aranacak Kelimeyi Giriniz:";
            label2.Text = "Hangi Satırda Aramak İstersiniz :";
            label3.Text = "Barkod :";
            label5.Text = "Fiyat :";
            label6.Text = "Kitap Adı :";
            label7.Text = "Tür :";
            label11.Text = "Yayınevi :";
            label13.Text = "Stok Adet :";
            btngüncelle.Text = "Güncelle";
            btnsil.Text = "Sil";
            btnsts.Text = "Hızlı Satış";
            button1.Text = "Tüm Kayıtları Göster :";
            groupBox1.Text = "Kayıtları Düzenle";
            lskkayıtlar.Columns.Clear();
            lskkayıtlar.Columns.Add("Barkod", 54, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Fiyat", 78, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("StokAdet", 73, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("KitapAdı", 88, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Yayınevi", 74, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Tür", 60, HorizontalAlignment.Left);
            yazıTipiToolStripMenuItem1.Text = "Yazı Tipi";
            arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            dilToolStripMenuItem.Text = "Dil";
            güncelleToolStripMenuItem.Text = "Güncelle";
            silToolStripMenuItem.Text = "Sil";
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
        }
        public void INGL()
        {
            Class1.secim = "İngilizce";
            label1.Text = "Search Word:";
            label2.Text = "Which is in Line to be Searched :";
            label3.Text = "Barcode :";
            label5.Text = "Price :";
            label6.Text = "Book Name :";
            label7.Text = "Type :";
            label11.Text = "Publisher :";
            label13.Text = "Stock Count :";
            btngüncelle.Text = "Update";
            btnsil.Text = "Delete";
            btnsts.Text = "Quick Sale";
            button1.Text = "All Records";
            groupBox1.Text = "Edit Records";
            lskkayıtlar.Columns.Clear();
            lskkayıtlar.Columns.Add("Barcode", 54, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Price", 78, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("StockCount", 73, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("BookName", 88, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Publisher", 74, HorizontalAlignment.Left);
            lskkayıtlar.Columns.Add("Type", 60, HorizontalAlignment.Left);
            yazıTipiToolStripMenuItem1.Text = "Font";
            arkaplanRengiToolStripMenuItem.Text = "Backcolor";
            dilToolStripMenuItem.Text = "Language";
            güncelleToolStripMenuItem.Text = "Update";
            silToolStripMenuItem.Text = "Delete";
            yazıTipiToolStripMenuItem.Text = "Font";
            yazıRengiToolStripMenuItem.Text = "Backgroundcolor";
            cmbarma.Items.Clear();
            cmbarma.Items.Add("Barcode");
            cmbarma.Items.Add("Price");
            cmbarma.Items.Add("StockCount");
            cmbarma.Items.Add("BookName");
            cmbarma.Items.Add("Publisher");
            cmbarma.Items.Add("Type");
        }
        private void pcbcikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            if (label3.Text == "Barkod :") cikis = MessageBox.Show("Çıkmak İstediğinden Emin Misin ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else cikis = MessageBox.Show("Are You Sure You Want to Exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
        public void aramayap()
        {
            cmd2.Connection = cnn;
            OleDbDataReader verioku = cmd2.ExecuteReader();
            lskkayıtlar.Items.Clear();
            while (verioku.Read())
            {
                ListViewItem item = lskkayıtlar.Items.Add(verioku["Barkod"].ToString());
                item.SubItems.Add(verioku["Fiyat"].ToString());
                item.SubItems.Add(verioku["StokAdet"].ToString());
                item.SubItems.Add(verioku["KitapAdı"].ToString());
                item.SubItems.Add(verioku["YayınEvi"].ToString());
                item.SubItems.Add(verioku["Tür"].ToString());
            }
            cmd2.Dispose();
        }
         private void KayitlariGoster()
        {
            lskkayıtlar.Items.Clear();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "SELECT * FROM kütüphane";
            cmd2.Connection = cnn;
            OleDbDataAdapter dap = new OleDbDataAdapter(cmd2);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            sayac = dt.Rows.Count;
            for (int i = 0; i < sayac; i++)
            {
                lskkayıtlar.Items.Add(dt.Rows[i]["Barkod"].ToString());
                lskkayıtlar.Items[i].SubItems.Add(dt.Rows[i]["Fiyat"].ToString());
                lskkayıtlar.Items[i].SubItems.Add(dt.Rows[i]["StokAdet"].ToString());
                lskkayıtlar.Items[i].SubItems.Add(dt.Rows[i]["KitapAdı"].ToString());
                lskkayıtlar.Items[i].SubItems.Add(dt.Rows[i]["Yayınevi"].ToString());
                lskkayıtlar.Items[i].SubItems.Add(dt.Rows[i]["Tür"].ToString());
            }
        }
         private void silme()
         {
             if (cnn.State.ToString() == "Closed") cnn.Open();
             DialogResult cks;
             if (label3.Text == "Barkod :")
             {
                 cks = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNoCancel);
             }
             else cks = MessageBox.Show("Are You Sure You Want To Delete The Record ?", "Warning", MessageBoxButtons.YesNoCancel);
             if (cks == DialogResult.Yes)
             {
                 try
                 {
                     OleDbCommand kmt = new OleDbCommand();
                     kmt = new OleDbCommand("DELETE FROM kütüphane Where Barkod='" + lskkayıtlar.FocusedItem.Text + "'");
                     kmt.Connection = cnn;
                     kmt.ExecuteNonQuery();
                     kmt.Dispose();
          if (label3.Text == "Barkod :")  MessageBox.Show("Kayıt Silinmiştir.","Başarıyla Silindi",MessageBoxButtons.OK,MessageBoxIcon.Information);
          else MessageBox.Show("Record Has Been Deleted.", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     if (lskkayıtlar.Items.Count != 0)
                     {
                         KayitlariGoster();
                     }
                 }
                 catch (Exception)
                 {
                     if (label3.Text == "Barkod :")MessageBox.Show("Lütfen Bir Kayıt Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     else MessageBox.Show("Please Select a Record In The", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         }
        public int sayac = 0;
        private void Varolan_Kayıtlar_Load(object sender, EventArgs e)
        {
            ekfttmr.Start();
            if (Class1.secim == "İngilizce") INGL();
            else  trk();
            tmrsaat.Start();
            cnn.Open();
        }
         private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double A;
            btngüncelle.Visible = true;
            btnsil.Visible = true;
            txtbarkod.Text = lskkayıtlar.FocusedItem.Text;
            A = Convert.ToDouble(lskkayıtlar.FocusedItem.SubItems[1].Text);
            txtfyt.Text = A.ToString();
            txtstok.Text = lskkayıtlar.FocusedItem.SubItems[2].Text;
            txtad.Text = lskkayıtlar.FocusedItem.SubItems[3].Text;
            txtyynv.Text = lskkayıtlar.FocusedItem.SubItems[4].Text;
            CMBTÜR.Text = lskkayıtlar.FocusedItem.SubItems[5].Text;
        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (cnn.State.ToString() == "Closed") cnn.Open();
            DialogResult kaydet;
            if (label3.Text == "Barkod :") kaydet = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            else kaydet = MessageBox.Show("Do You Want To Update Your Record?", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            if (kaydet == DialogResult.Yes)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE kütüphane SET Barkod='" + txtbarkod.Text + "',Fiyat='"+txtfyt.Text+ "',StokAdet='" + txtstok.Text + "',KitapAdı='" + txtad.Text + "',Yayınevi='" + txtyynv.Text + "',Tür='" + CMBTÜR.SelectedItem.ToString() + "' WHERE Barkod='" + lskkayıtlar.FocusedItem.Text + "'";
                    cmd.Connection = cnn;
                    cmd.ExecuteNonQuery();
                    if (label3.Text == "Barkod :") MessageBox.Show("Kayıt Güncellendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else MessageBox.Show("Record updated.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (lskkayıtlar.Items.Count!=0)
                    {
                        KayitlariGoster();
                    }
                    
                }
                catch (Exception)
                {
                    if (label3.Text == "Barkod :") MessageBox.Show("Lütfen Bir Kayıt Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Please Select a Record In The", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            silme();
        }
        OleDbCommand cmd2 = new OleDbCommand();
        private void aranankelime_TextChanged(object sender, EventArgs e)
        {
            if (cnn.State.ToString() == "Closed") cnn.Open();
            try
            {
                if (cmbarma.SelectedItem.ToString() == "Barkod" || cmbarma.SelectedItem.ToString() == "Barcode")
                {
                    if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where Barkod ='" + aranankelime.Text.Trim() + "'";
                        aramayap();}
                }
                if (cmbarma.SelectedItem.ToString() == "Fiyat"||cmbarma.SelectedItem.ToString() == "Price")
                {
                   if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where Fiyat='" + aranankelime.Text.Trim() + "'";
                        aramayap();
                    }
                }
                if (cmbarma.SelectedItem.ToString() == "StokAdet"||cmbarma.SelectedItem.ToString() == "StockCount")
                {
                     if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where StokAdet='" + aranankelime.Text.Trim() + "'";
                        aramayap();
                }
                }
                if (cmbarma.SelectedItem.ToString() == "KitapAdı"||cmbarma.SelectedItem.ToString() == "BookName")
                {
                     if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where KitapAdı='" + aranankelime.Text.Trim() + "'";
                        aramayap();
                    }
                }
                if (cmbarma.SelectedItem.ToString() == "Yayınevi"||cmbarma.SelectedItem.ToString() == "Publisher")
                {
                    if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where Yayınevi='" + aranankelime.Text.Trim() + "'";
                        aramayap();
                    }
                }
                if (cmbarma.SelectedItem.ToString() == "Tür"||cmbarma.SelectedItem.ToString() == "Type")
                {
                    if (aranankelime.Text != "")
                    {
                        cnn.Close();
                        cnn.Open();
                        cmd2.CommandText = "Select * From kütüphane Where Tür='" + aranankelime.Text.Trim() + "'";
                        aramayap();
                    }
                }
            }
            catch (Exception)
            {
                if (label3.Text == "Barkod :") MessageBox.Show("Önce Satır Seçiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else MessageBox.Show("Select the row before", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsts_Click(object sender, EventArgs e)
        {
            satıs sts = new satıs();
            sts.Show();
            this.Hide();
        }
       private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 980;
            pcbcikis.Left = 950; label4.Top = 30; label4.Left = 850;
            pcbgeri.Left = 950;
        }
         private void pcbgeri_Click(object sender, EventArgs e)
        {
            Anaform afm = new Anaform();
            afm.Show();
            this.Hide();
         }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            silme();
        }
         private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lskkayıtlar.Font = fontDialog1.Font;
        }
          private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lskkayıtlar.ForeColor = colorDialog1.Color;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KayitlariGoster();
        }
          private void tmrsaat_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }
          private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
          {
              colorDialog1.ShowDialog();
              this.BackColor = colorDialog1.Color; label4.BackColor = colorDialog1.Color;
          }
          private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
          {
              fontDialog1.ShowDialog();
              label1.Font = fontDialog1.Font; label2.Font = fontDialog1.Font; label3.Font = fontDialog1.Font;
              label4.Font = fontDialog1.Font; label5.Font = fontDialog1.Font; label6.Font = fontDialog1.Font;
              label7.Font = fontDialog1.Font; label11.Font = fontDialog1.Font; btngüncelle.Font = fontDialog1.Font;
              btnsil.Font = fontDialog1.Font; btnsts.Font = fontDialog1.Font; button1.Font = fontDialog1.Font;
          }
         private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
          {
              trk();
          }
          private void englishToolStripMenuItem_Click(object sender, EventArgs e)
          {
              INGL();
          }
         private void txtstok_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)e.Handled = false;
             else e.Handled = true;
         }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
         {
             colorDialog1.ShowDialog();
             label1.ForeColor = colorDialog1.Color;
             label2.ForeColor = colorDialog1.Color;
             label3.ForeColor = colorDialog1.Color;
             label4.ForeColor = colorDialog1.Color;
             label5.ForeColor = colorDialog1.Color;
             label6.ForeColor = colorDialog1.Color;
             label7.ForeColor = colorDialog1.Color;
             label13.ForeColor = colorDialog1.Color;
             label11.ForeColor = colorDialog1.Color;
             btngüncelle.ForeColor = colorDialog1.Color;
             btnsil.ForeColor = colorDialog1.Color;
             btnsts.ForeColor = colorDialog1.Color;
             button1.ForeColor = colorDialog1.Color;
          }

        private void ekfttmr_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100) this.Opacity = this.Opacity + 5 * 0.01;
            else ekfttmr.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sivrilerbilisim.com/");

        }
    }
}

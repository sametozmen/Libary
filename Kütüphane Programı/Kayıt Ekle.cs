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
    public partial class Kayıt_Ekle : Form
    {
        public Kayıt_Ekle()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphanem.accdb;Persist Security Info=False");
        public void ingilizce()
        {
            Class1.secim = "İngilizce";
            label5.Text = "Barcode:";
            label1.Text = "Price:";
            label2.Text = "Stock Count:";
            label3.Text = "Book Name:";
            label4.Text = "Publisher:";
            label8.Text = "type:";
            btnkyt.Text = "Add Recording";
            groupBox1.Text = "Add Recording";
            yazıBoyutlarıToolStripMenuItem.Text = "Font";
            arkaplanRengiToolStripMenuItem.Text = "Backcolor";
            dilToolStripMenuItem.Text = "Language";
        }
        public void Trkce()
        {
            Class1.secim = "Türkçe";
            label5.Text = "Barkod:";
            label1.Text = "Fiyat:";
            label2.Text = "Stok Adet:";
            label3.Text = "Kitap Adı:";
            label4.Text = "Yayınevi:";
            label8.Text = "Tür:";
            btnkyt.Text = "Kayıt Ekle";
            groupBox1.Text = "Kayıt Ekle";
            yazıBoyutlarıToolStripMenuItem.Text = "Yazı Tipi";
            arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            dilToolStripMenuItem.Text = "Dil";
        }
        private void pcbcikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            if (groupBox1.Text == "Kayıt Ekle")cikis = MessageBox.Show("Çıkmak İstediğinden Emin Misin ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else cikis = MessageBox.Show("Are You Sure You Want to Exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
       private void Kayıt_Ekle_Load(object sender, EventArgs e)
        {
            tmrfkt.Start();
            if (Class1.secim=="İngilizce")ingilizce();
            else Trkce();
            tmrsaat.Start();
            cnn.Open();
            tmrktphne.Start();
            txtfiyat.Maximum = int.MaxValue;
        }
        private void btnkyt_Click(object sender, EventArgs e)
        {
            if (txtfiyat.Text != "" && txtbarkod.Text != "" && txtkitap.Text != "" && txtstok.Text != "" && CMBTÜR.Text != "" && txtyyınev.Text != "")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Insert Into Kütüphane(Barkod,Fiyat,StokAdet,KitapAdı,Yayınevi,Tür) Values('" + txtbarkod.Text + "','" + txtfiyat.Text + "'," + txtstok.Text + ",'" + txtkitap.Text + "','" + txtyyınev.Text + "','" + CMBTÜR.Text + "')";
                    cmd.Connection = cnn;
                    cmd.ExecuteNonQuery();
                    if (groupBox1.Text=="Kayıt Ekle")MessageBox.Show("Kayıtınız Başarı İle Eklenmiştir","Eklendi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                     else MessageBox.Show("Record Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Hand);
               }
                  catch (Exception)
                {
                    if (groupBox1.Text=="Kayıt Ekle") MessageBox.Show("Bu Barkodlu Ürün Zaten Kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("This product is on the list with Barcode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             }
            else
            {
                if (groupBox1.Text == "Kayıt Ekle") MessageBox.Show("Gerekli Alanları Doludurmalısın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show(" You must fill in the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pcbgeri_Click(object sender, EventArgs e)
        {
            Anaform afm = new Anaform();
            afm.Show();
            this.Hide();
        }
         private void tmrsaat_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
        }
         private void txtstok_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8) e.Handled = false;
             else e.Handled = true;
         }
         private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
         {
             colorDialog1.ShowDialog();
             this.BackColor = colorDialog1.Color; label6.BackColor = colorDialog1.Color;
         }
         private void yazıBoyutlarıToolStripMenuItem_Click(object sender, EventArgs e)
         {
             fontDialog1.ShowDialog();
             label1.Font = fontDialog1.Font;
             label2.Font = fontDialog1.Font;
             label3.Font = fontDialog1.Font;
             label4.Font = fontDialog1.Font;
             label5.Font = fontDialog1.Font;
             label6.Font = fontDialog1.Font;
             btnkyt.Font = fontDialog1.Font;
         }
         private void englishToolStripMenuItem_Click(object sender, EventArgs e)
         {
             ingilizce();
         }
         private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Trkce();
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
             label8.ForeColor = colorDialog1.Color;
             btnkyt.ForeColor = colorDialog1.Color;
            
         }

         private void tmrfkt_Tick(object sender, EventArgs e)
         {
             if (this.Opacity < 100) this.Opacity = this.Opacity + 5 * 0.01;
             else tmrfkt.Stop();
         }

         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             System.Diagnostics.Process.Start("http://sivrilerbilisim.com/");
         }
      }
}

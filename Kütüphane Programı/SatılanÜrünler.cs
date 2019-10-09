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
    public partial class SatılanÜrünler : Form
    {
        public SatılanÜrünler()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kütüphanem.accdb;Persist Security Info=False");
        private void pcbgeri_Click(object sender, EventArgs e)
        {
            Anaform afm = new Anaform();
            afm.Show();
            this.Hide();
        }
         private void pcbcikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            if (Class1.secim == "Türkçe")cikis = MessageBox.Show("Çıkmak İstediğinden Emin Misin ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else cikis = MessageBox.Show("Are You Sure You Want to Exit  ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
           private void SatılanÜrünler_Load(object sender, EventArgs e)
         {
             tmrefkt.Start();
             if (Class1.secim == "İngilizce") INGYAP();
             else TRKYAP();
             bool a = true;
             tmrsaat.Start();
             OleDbCommand cmd2 = new OleDbCommand();
             cmd2.CommandText = "SELECT * FROM satislar";
             cmd2.Connection = cnn;
             OleDbDataAdapter dap = new OleDbDataAdapter(cmd2);
             DataTable dt = new DataTable();
             dap.Fill(dt);
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 for (int j = 0; j < cmbtarih.Items.Count; j++)
                 {
                     if (dt.Rows[i]["tarih"].ToString() == cmbtarih.Items[j].ToString()) a = false;
                 }
                 if (a == true) cmbtarih.Items.Add(dt.Rows[i]["tarih"].ToString());
             }
             
         }
        private void tmrsaat_Tick(object sender, EventArgs e)
         {
             label2.Text = DateTime.Now.ToLongTimeString();
         }
         OleDbCommand cmd2 = new OleDbCommand();
         public double toplampara=0;
         public int sycpr = 0;
          private void cmbtarih_SelectedIndexChanged(object sender, EventArgs e)
         {
             sycpr = 0;
             toplampara = 0;
             lskkayıtlar.Items.Clear();
             if (cnn.State.ToString() == "Closed") cnn.Open();
             cmd2.CommandText = "Select * From satislar Where tarih = '" + cmbtarih.Text + "'";
             cmd2.Connection = cnn;
             cnn.Close();
             cnn.Open();
             OleDbDataReader verioku = cmd2.ExecuteReader();
             while (verioku.Read())
             {
                 ListViewItem item = lskkayıtlar.Items.Add(verioku["Barkod"].ToString());
                 item.SubItems.Add(verioku["KitapAdı"].ToString());
                 item.SubItems.Add(verioku["SatılanAdet"].ToString());
                 item.SubItems.Add(verioku["Fiyatı"].ToString());
                 item.SubItems.Add(verioku["ToplamFiyat"].ToString());
                 item.SubItems.Add(verioku["Tarih"].ToString());
                 item.SubItems.Add(verioku["Saat"].ToString());
                 toplampara = toplampara + Convert.ToDouble(lskkayıtlar.Items[sycpr].SubItems[4].Text);
                 sycpr++;
             }
             label4.Text = toplampara.ToString();
         }
        public void INGYAP()
          {
              label1.Text = "Select the Date :";
              Class1.secim = "İngilizce";
              lskkayıtlar.Columns.Clear();
              lskkayıtlar.Columns.Add("Barcode", 99, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("BookName", 119, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("SoldPieces", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Price", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("TotalPrice", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Date", 70, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Clock", 120, HorizontalAlignment.Left);
              label3.Text = "the Total Money Earned :";
              arkaplanRengiToolStripMenuItem.Text = "Backcolor";
              yazıTipiToolStripMenuItem1.Text = "Font";
              yazıRengiToolStripMenuItem1.Text = "Backgroundcolor";
              dilToolStripMenuItem1.Text = "Language";
          }
          public void TRKYAP()
          {
              label1.Text = "Tarih Seçimini Yapınız :";
              Class1.secim = "Türkçe";
              lskkayıtlar.Columns.Clear();
              lskkayıtlar.Columns.Add("Barkod", 99, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("KitapAdı", 119, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("SatılanAdet", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Fiyat", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("ToplamFiyat", 85, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Tarih", 70, HorizontalAlignment.Left);
              lskkayıtlar.Columns.Add("Saat", 120, HorizontalAlignment.Left);
              label3.Text = "Kazanılan Toplam Para :";
              arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
              yazıTipiToolStripMenuItem1.Text = "Yazı Tipi";
              yazıRengiToolStripMenuItem1.Text = "Yazı Rengi";
              dilToolStripMenuItem1.Text = "Dil";
          }
         private void englisgToolStripMenuItem_Click(object sender, EventArgs e)
          {
              INGYAP();
          }
         private void türkçeToolStripMenuItem1_Click(object sender, EventArgs e)
          {
              TRKYAP();
          }
         private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
          {
              fontDialog1.ShowDialog();
              lskkayıtlar.Font = fontDialog1.Font;
              label1.Font = fontDialog1.Font;
              label2.Font = fontDialog1.Font;
          }
         private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
          {
              colorDialog1.ShowDialog();
              this.BackColor = colorDialog1.Color;
          }
         private void yazıRengiToolStripMenuItem1_Click(object sender, EventArgs e)
          {
              colorDialog1.ShowDialog();
              label2.ForeColor = colorDialog1.Color;
              label3.ForeColor = colorDialog1.Color;
              label4.ForeColor = colorDialog1.Color;
              label5.ForeColor = colorDialog1.Color;
          }

         private void tmrefkt_Tick(object sender, EventArgs e)
         {
             if (this.Opacity < 100) this.Opacity = this.Opacity + 5 * 0.01;
             else tmrefkt.Stop();
         }

         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             System.Diagnostics.Process.Start("http://sivrilerbilisim.com/");

         }
    }
}

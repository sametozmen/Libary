using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Programı
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
         private void pcbcikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            if (btnekle.Text == "Kayıt Ekle") cikis = MessageBox.Show("Çıkmak İstediğinden Emin Misin", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else cikis = MessageBox.Show("Are You Sure You Want to Exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
         private void btnekle_Click(object sender, EventArgs e)
        {
            Kayıt_Ekle kyt = new Kayıt_Ekle();
            kyt.Show();
            this.Hide();
        }
        private void btnvarolanlar_Click(object sender, EventArgs e)
        {
            Varolan_Kayıtlar var = new Varolan_Kayıtlar();
            var.Show();
            this.Hide();
        }
       private void button1_Click(object sender, EventArgs e)
        {
            satıs sts = new satıs();
            sts.Show();
            this.Hide();
        }
         private void Anaform_Load(object sender, EventArgs e)
        {
            tmrefekt.Start();
            if (Class1.secim == "İngilizce")
            {
                Class1.secim = "İngilizce";
                btnekle.Text = "Add Recording";
                btnsatıs.Text = "Quick Sale";
                btnvarolanlar.Text = "Existing Records";
                groupBox1.Text = "Library";
                yazıTipiToolStripMenuItem.Text = "Font";
                arkaplanRengiToolStripMenuItem.Text = "Backcolor";
                dilToolStripMenuItem.Text = "Language";
            }
            else
            {
                Class1.secim = "Türkçe";
                btnekle.Text = "Kayıt Ekle";
                btnsatıs.Text = "Hızlı Satış";
                btnvarolanlar.Text = "Varolan Kayıtlarım";
                groupBox1.Text = "Kütüphanem";
            }
            tmrsaat.Start();
        }
        private void tmrsaat_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color; label1.BackColor = colorDialog1.Color;
        }
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font; btnekle.Font = fontDialog1.Font; btnsatıs.Font = fontDialog1.Font; btnvarolanlar.Font = fontDialog1.Font;
        }
        
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.secim = "İngilizce";
            btnekle.Text = "Add Recording";
            btnsatıs.Text = "Quick Sale";
            btnvarolanlar.Text = "Existing Records";
            groupBox1.Text = "Library";
            yazıTipiToolStripMenuItem.Text = "Font";
            arkaplanRengiToolStripMenuItem.Text = "Backcolor";
            dilToolStripMenuItem.Text = "Language";
        }
         private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.secim = "Türkçe";
            btnekle.Text = "Kayıt Ekle";
            btnsatıs.Text = "Hızlı Satış";
            btnvarolanlar.Text = "Varolan Kayıtlarım";
            groupBox1.Text = "Kütüphanem";
        }

         private void tmrefekt_Tick(object sender, EventArgs e)
         {

             if (this.Opacity < 100) this.Opacity = this.Opacity + 5 * 0.01;
             else tmrefekt.Stop();
         }

         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             System.Diagnostics.Process.Start("http://sivrilerbilisim.com/");
         }
        
     }
}

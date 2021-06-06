using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunSatis
{
    public partial class Frmİstatikler : Form
    {
        public Frmİstatikler()
        {
            InitializeComponent();
        }
        SatisMagzaEntities db = new SatisMagzaEntities();
        int stok = 0;
        int sayac = 0;
        private void Frmİstatikler_Load(object sender, EventArgs e)
        {
       
            label2.Text = db.Tbl_SatisUrun.Sum(x => x.URUNSTOK).ToString();
            label8.Text = db.Tbl_SatisUrun.Max(z => z.URUNFIYAT).ToString();
            label9.Text = db.Tbl_SatisUrun.Min(z => z.URUNFIYAT).ToString();
            label10.Text = db.Tbl_SatisUrun.Count(z => z.URUNADI == "PANTOLON").ToString();
            label11.Text = db.Tbl_SatisUrun.Count(f => f.URUNADI == "V YAKALI T-SHIRT" || f.URUNADI == "BIS. YAKALI T-SHIRT").ToString();
            label12.Text = db.Tbl_SatisUrun.Count(h => h.URUNADI == "AYAKKABI").ToString();
            label14.Text = db.KABANGETiR2().FirstOrDefault().ToString();
            stok = int.Parse(label14.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (stok <= 10)
            {
                pictureBox7.BackColor = Color.Red;
                label13.BackColor = Color.Red;
                label15.BackColor = Color.Red;
                label14.BackColor = Color.Red;
                label15.Visible = true;
                if (sayac % 2 == 0)
                {
                    pictureBox7.BackColor = Color.White;
                    label13.BackColor = Color.White;
                    label15.BackColor = Color.White;
                    label14.BackColor = Color.White;
                }
            }
        }

        FrmArayuz ara = new FrmArayuz();
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ara.Show();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ara.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ara.Show();
            Application.Exit();

        }

        private void label17_Click(object sender, EventArgs e)
        {
            ara.Show();
            Application.Exit();

        }


    }
}

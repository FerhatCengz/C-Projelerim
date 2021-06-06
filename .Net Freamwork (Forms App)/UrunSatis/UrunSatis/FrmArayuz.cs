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
    public partial class FrmArayuz : Form
    {
        public FrmArayuz()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle urun = new FrmUrunEkle();
            urun.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frmİstatikler frm = new Frmİstatikler();
            frm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmSatisPaneli satis = new FrmSatisPaneli();
            satis.Show();
            this.Close();
        }

        SatisMagzaEntities db = new SatisMagzaEntities();
        private void FrmArayuz_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = db.KABANGETiR2().FirstOrDefault().ToString();


            if (int.Parse(label1.Text) <= 10)
            {
                pictureBox5.Visible = true;
            }

        }
    }
}

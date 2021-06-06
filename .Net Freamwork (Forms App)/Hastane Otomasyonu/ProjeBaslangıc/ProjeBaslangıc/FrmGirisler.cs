using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeBaslangıc
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGiris hstgrs = new HastaGiris();
            hstgrs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris giris = new FrmDoktorGiris();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris giris = new FrmSekreterGiris();
            giris.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmDoktorGiris dr = new FrmDoktorGiris();
            dr.Show();
            this.Hide();
        }
    }
}

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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SatisMagzaEntities db = new SatisMagzaEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            //var giris = (from x in db.Tbl_Admin where x.KAD == textBox1.Text && x.PASS == textBox2.Text select x);
            //if (giris.Any())
            //{
                FrmArayuz ara = new FrmArayuz();
                ara.Show();
                this.Hide();
            //}

            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı ve Parola Hatatlı");
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

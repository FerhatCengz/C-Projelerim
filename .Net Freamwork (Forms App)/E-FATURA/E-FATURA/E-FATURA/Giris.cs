using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_FATURA
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "Ergin" || textBox1.Text == "ergin" && textBox2.Text == "1234")
            {
                Arayüz arayuz = new Arayüz();
                arayuz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Ve Ya Şifreniz Yanlıştır", "Hata ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

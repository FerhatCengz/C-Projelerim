using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaymak
{
    public partial class KADPAS : Form
    {
        public KADPAS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
          
            string x, y;
            x = textBox1.Text;
            y = textBox2.Text;
            if (x == "orhan" && y == "orhan")
            {
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRE HATALI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }
    }
}

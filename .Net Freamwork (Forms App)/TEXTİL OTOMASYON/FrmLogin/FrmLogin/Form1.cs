using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace FrmLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }



        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        sqlitebaglanti bgl = new sqlitebaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Kad , Pass From Tbl_Kullanici Where Kad = @p1 and Pass = @p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmArayuz ara = new FrmArayuz();
                ara.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Ve ya Parola Hatalı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void textBox1_MouseHover_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

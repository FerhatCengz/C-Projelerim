using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace E_Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();


   

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenciler Where Og_ID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                FrmOgrenciNotlar not = new FrmOgrenciNotlar();
                not.numara = textBox1.Text;
                not.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmdogr = new SqlCommand("SELECT * FROM Tbl_Ogretmen Where Ogr_Brans = @p1 and Ogr_Parola = @p2", bgl.baglanti());
            cmdogr.Parameters.AddWithValue("@p1", textBox1.Text);
            cmdogr.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cmdogr.ExecuteReader();
            while (dr.Read())
            {
                FrmOgretmen ogrg = new FrmOgretmen();
                ogrg.id = textBox1.Text;
                ogrg.parola = textBox2.Text;
                ogrg.Show();
                this.Hide();
            }


        }

      

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

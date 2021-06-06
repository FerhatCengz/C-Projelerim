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

namespace Kaymak
{
    public partial class Notlarim : Form
    {
        public Notlarim()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");

        public void listele()
        {



            baglanti.Open();
            SQLiteCommand tbl_not = new SQLiteCommand("Select * From tbl_notlar", baglanti);
            SQLiteDataReader dr = tbl_not.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0] + " - )  " + dr[1]);
            }
            baglanti.Close();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand veri_not = new SQLiteCommand("insert into tbl_notlar(Notlar) VALUES(@o1)", baglanti);
            veri_not.Parameters.AddWithValue("@o1", " ( " + dateTimePicker1.Value + " )" + richTextBox1.Text);
            veri_not.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Kayıt Edildi");
        }

        private void Notlarim_Load(object sender, EventArgs e)
        {
           
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand delete_notlar = new SQLiteCommand("DELETE FROM tbl_notlar where ID = @k1", baglanti);
            delete_notlar.Parameters.AddWithValue("@k1", textBox1.Text);
            delete_notlar.ExecuteNonQuery();
            baglanti.Close();
            listele();

            Notlarim not = new Notlarim();
            this.Close();
            not.Show();

        }


        int sayacartir = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            sayacartir += 10;
            textBox1.Text = sayacartir.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayacartir > 0)
            {
                sayacartir -= 10;
                textBox1.Text = sayacartir.ToString();
            }
        }
    }
}

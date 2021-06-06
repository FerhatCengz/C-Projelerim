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
    public partial class FrmAra : Form
    {
        public FrmAra()
        {
            InitializeComponent();
        }
        sqlitebaglanti bgl = new sqlitebaglanti();
        void listele()
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;

            DataTable dt = new DataTable();
            SQLiteDataAdapter dp = new SQLiteDataAdapter("SELECT * FROM Personel", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void FrmAra_Load_1(object sender, EventArgs e)
        {
            dataGridView2.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;

            dataGridView2.Visible = false;
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Personel Where ADI LIKE '%" + ad_text.Text + "%' And SOYADI LIKE '%" + soyad_text.Text + "%' ", bgl.baglanti());
            SQLiteDataAdapter dp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;


            SQLiteCommand cmd2 = new SQLiteCommand("SELECT ADI ,SOYADI , SUM(MAAS) AS MAAS , SUM(AVANS) AS AVANS , SUM(G_G_S) AS GELMEDIGI_GUN_S , SUM(TOTAL) AS TOTAL From Personel Where ADI LIKE '%" + ad_text.Text + "%' And SOYADI LIKE '%" + soyad_text.Text + "%'", bgl.baglanti());
            SQLiteDataAdapter dp2 = new SQLiteDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            dp2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            ad_text.Text = "";
            soyad_text.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            tarihbtn.Visible = true;
            button1.Visible = false;
            label3.Visible = false;
            label6.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ad_text.Text = "";
            soyad_text.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            tarihbtn.Visible = false;
            button1.Visible = true;
            label6.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
        }

        private void tarihbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;


            SQLiteCommand cmd = new SQLiteCommand("SELECT ADI , SOYADI , MEVKI , G_G_S AS GELMEDIGI_G_S , MAAS AS MAAS , AVANS AS AVANS, TOTAL From Personel Where ADI LIKE '%" + ad_text.Text + "%' And SOYADI LIKE '%" + soyad_text.Text + "%' and TARIH BETWEEN @tarih and @tarih2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih2", maskedTextBox2.Text);
            SQLiteDataAdapter dp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;


            SQLiteCommand cmd2 = new SQLiteCommand("SELECT ADI , SOYADI , SUM (MAAS) AS MAAS , SUM(AVANS) AS AVANS, SUM(TOTAL)AS TOTAL  From Personel Where ADI LIKE '%" + ad_text.Text + "%' And SOYADI LIKE '%" + soyad_text.Text + "%' and TARIH BETWEEN @tarih3 and @tarih4", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@tarih3", maskedTextBox1.Text);
            cmd2.Parameters.AddWithValue("@tarih4", maskedTextBox2.Text);
            SQLiteDataAdapter dp2 = new SQLiteDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            dp2.Fill(dt2);
            dataGridView2.DataSource = dt2;




        }
    }
}

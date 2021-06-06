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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        sqlitebaglanti bgl = new sqlitebaglanti();
        private void FrmGrafik_Load(object sender, EventArgs e)
        {








        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT(ADI) , MAAS FROM Personel WHERE TARIH BETWEEN @k1 and @k2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@k1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@k2", maskedTextBox2.Text);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Eleman"].Points.AddXY(dr[0], dr[1]);
            }
            bgl.baglanti().Close();
            SQLiteCommand cmd2 = new SQLiteCommand("SELECT DISTINCT(ADI) , AVANS FROM Personel WHERE TARIH BETWEEN @p1 and @p2", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd2.Parameters.AddWithValue("@p2", maskedTextBox2.Text);
            SQLiteDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Avans"].Points.AddXY(dr2[0], dr2[1]);
            }
            bgl.baglanti().Close();

            SQLiteCommand cmd3 = new SQLiteCommand("SELECT DISTINCT(ADI) , G_G_S FROM Personel Where TARIH BETWEEN @tarih AND @tarih2", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
            cmd3.Parameters.AddWithValue("@tarih2", maskedTextBox2.Text);
            SQLiteDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                chart3.Series["GELMEDIGI GUN"].Points.AddXY(dr3[0], dr3[1]);
            }

            bgl.baglanti().Close();

            button1.Visible = false;
            button2.Visible = true;

        }

        int sayac = 4;

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmGrafik grf = new FrmGrafik();


            sayac--;
            button2.Text = " Tekrar Ara (" + sayac + ")";
            if (sayac == 0)
            {
                timer1.Stop();
                this.Close();
                grf.Show();
            }
        }
    }
}

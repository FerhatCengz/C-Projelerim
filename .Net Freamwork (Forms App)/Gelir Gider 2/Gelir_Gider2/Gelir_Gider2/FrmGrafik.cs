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
using MaterialSkin.Controls;
namespace Gelir_Gider2
{
    public partial class FrmGrafik : MaterialForm
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection(@"Data Source = C:\Veri\Hesap2.db; Version=3;");
        public string tarih;
        public int idtarih;

        void chart_verileri()
        {
            if (idtarih == 11)
            {

                this.Text = tarih;

                baglanti.Open();
                SQLiteCommand sQ = new SQLiteCommand("SELECT DISTINCT(Adi) , REPLACE(Money,'TL','') From Tbl_Giderler Where Tarih = @t and Money >= 300", baglanti);
                sQ.Parameters.AddWithValue("@t", tarih);
                SQLiteDataReader reader = sQ.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["En Fazla Gider"].Points.AddXY(reader[0], reader[1]);
                }
                baglanti.Close();


                baglanti.Open();
                SQLiteCommand sQ2 = new SQLiteCommand("SELECT DISTINCT(Adi) , REPLACE(Money,'TL','') From Tbl_Giderler Where Tarih = @t2 and Money <= 299", baglanti);
                sQ2.Parameters.AddWithValue("@t2", tarih);
                SQLiteDataReader sQLite = sQ2.ExecuteReader();
                while (sQLite.Read())
                {
                    chart2.Series["En Az Gider"].Points.AddXY(sQLite[0], sQLite[1]);

                }

                baglanti.Close();
            }
            else
            {
                this.Text = "Tüm Sonuclar";

                chart2.Visible = false;
                chart1.Size = new Size(1168, 341);
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                baglanti.Open();
                SQLiteCommand sQ = new SQLiteCommand("SELECT DISTINCT(Adi) , REPLACE(Money,'TL','') From Tbl_Giderler", baglanti);
                SQLiteDataReader reader = sQ.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["En Fazla Gider"].Points.AddXY(reader[0], reader[1]);

                }
                baglanti.Close();




                baglanti.Open();

                SQLiteCommand sQ2 = new SQLiteCommand("SELECT SUM(REPLACE(Money,'TL','')) From Tbl_Giderler", baglanti);
                SQLiteDataReader reader2 = sQ2.ExecuteReader();
                while (reader2.Read())
                {
                    label7.Text = reader2[0].ToString();

                }

                baglanti.Close();



            }

        }

        void boxverileri()
        {
            baglanti.Open();
            SQLiteCommand sQ = new SQLiteCommand("SELECT MoneyStart From Tbl_Money Where MoneyTarih = @t3 ", baglanti);
            sQ.Parameters.AddWithValue("@t3", tarih);
            SQLiteDataReader dr = sQ.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr[0] + " TL";
            }


            baglanti.Close();



            baglanti.Open();
            SQLiteCommand sQ2 = new SQLiteCommand("SELECT SUM(REPLACE(Money,'TL','')) From Tbl_Giderler Where Tarih = @t4 ", baglanti);
            sQ2.Parameters.AddWithValue("@t4", tarih);
            SQLiteDataReader dr2 = sQ2.ExecuteReader();
            while (dr2.Read())
            {
                label7.Text = dr2[0] + " TL";
            }


            baglanti.Close();


            baglanti.Open();
            SQLiteCommand sQ3 = new SQLiteCommand("SELECT Adi , MAX(REPLACE(Money,'TL','')) From Tbl_Giderler Where Tarih = @t4 ", baglanti);
            sQ3.Parameters.AddWithValue("@t4", tarih);
            SQLiteDataReader dr3 = sQ3.ExecuteReader();
            while (dr3.Read())
            {
                label9.Text = dr3[1] + " TL";
                label11.Text = dr3[0].ToString();
            }


            baglanti.Close();





            baglanti.Open();

            SQLiteCommand sQ4 = new SQLiteCommand("SELECT DISTINCT(Adi) , MIN(REPLACE(Money,'TL','')) From Tbl_Giderler Where Tarih = @t5", baglanti);
            sQ4.Parameters.AddWithValue("@t5", tarih);
            SQLiteDataReader dr4 = sQ4.ExecuteReader();
            while (dr4.Read())
            {
                label8.Text = dr4[1] + " TL";
                label12.Text = dr4[0].ToString();
            }


            baglanti.Close();



            baglanti.Open();

            SQLiteCommand sQ5 = new SQLiteCommand("SELECT MoneyTutar From Tbl_Money Where MoneyTarih = @t5", baglanti);
            sQ5.Parameters.AddWithValue("@t5", tarih);
            SQLiteDataReader dr5 = sQ5.ExecuteReader();
            while (dr5.Read())
            {
                label10.Text = dr5[0].ToString();
            }


            baglanti.Close();
        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            chart_verileri();
            boxverileri();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("300 Tl'den Aşşağa Gösterir","Bİlgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("300 TL VE YUKARI GÖSTERİR", "Bilginlendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

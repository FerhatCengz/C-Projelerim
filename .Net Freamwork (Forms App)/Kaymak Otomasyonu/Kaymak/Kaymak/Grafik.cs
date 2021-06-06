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
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");


        private void Grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand yazdır = new SQLiteCommand("Select DISTINCT(MAGZA_ADI) , SUM(ADET) From tbl_kaymak Group by MAGZA_ADI", baglanti);
            SQLiteDataReader yazdırread = yazdır.ExecuteReader();
            while (yazdırread.Read())
            {
                chart1.Series["Adet"].Points.AddXY(yazdırread[0], yazdırread[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SQLiteCommand satis = new SQLiteCommand("Select DISTINCT(TARIH) , SUM(ADET + KG) From tbl_kaymak Group by TARIH", baglanti);
            SQLiteDataReader readder = satis.ExecuteReader();
            while (readder.Read())
            {
                chart2.Series["Tarihe Göre Satışı"].Points.AddXY(readder[0], readder[1]);

            }
            baglanti.Close();


            baglanti.Open();
            SQLiteCommand adetort = new SQLiteCommand("Select DISTINCT(MAGZA_ADI) , AVG(ADET) From tbl_kaymak Group by TARIH", baglanti);
            SQLiteDataReader adetortread = adetort.ExecuteReader();
            while (adetortread.Read())
            {
                chart3.Series["ADET ORTALAMA"].Points.AddXY(adetortread[0], adetortread[1]);
            }
            baglanti.Close();


            baglanti.Open();
            SQLiteCommand ciro = new SQLiteCommand("Select DISTINCT(MAGZA_ADI) , SUM(TUTAR)  From tbl_Kaymak Group by TARIH", baglanti);
            SQLiteDataReader cirooread = ciro.ExecuteReader();
            while (cirooread.Read())
            {
                chart4.Series["CİRO"].Points.AddXY(cirooread[0], cirooread[1]);
            }

            baglanti.Close();





            baglanti.Open();
            SQLiteCommand ciro2 = new SQLiteCommand("Select DISTINCT(MAGZA_ADI) , SUM(KG)  From tbl_Kaymak Group by MAGZA_ADI", baglanti);
            SQLiteDataReader cirooread2 = ciro2.ExecuteReader();
            while (cirooread2.Read())
            {
                chart5.Series["KG"].Points.AddXY(cirooread2[0], cirooread2[1]);
            }

            baglanti.Close();



            baglanti.Open();
            SQLiteCommand ciro3 = new SQLiteCommand("Select DISTINCT(MAGZA_ADI) , AVG(KG)  From tbl_Kaymak Group by TARIH", baglanti);
            SQLiteDataReader cirooread3 = ciro3.ExecuteReader();
            while (cirooread3.Read())
            {
                chart6.Series["KG ORTALAMA"].Points.AddXY(cirooread3[0], cirooread3[1]);
            }

            baglanti.Close();



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

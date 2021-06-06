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
using Excel = Microsoft.Office.Interop.Excel;

namespace Kaymak
{
    public partial class Filitre : Form
    {
        public Filitre()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");


        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            string sql = "SELECT MAGZA_ADI , ADI , SOYADI , FIYAT,ADET, KG ,TUTAR, VERILEN , KALAN , TARIH FROM tbl_kaymak Where TARIH BETWEEN @tarih1 and @tarih2 and MAGZA_ADI LIKE '%" + textBox1.Text + "%' ORDER BY TARIH ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);
          



            baglanti.Open();

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("BAŞLANGIÇ TARİHİ BİTİŞ TARİHİNDEN BÜYÜK YA DA EŞİT OLAMAZ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Visible = false;
            }

            else
            {
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
            }


            baglanti.Close();
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Excel_Click_1(object sender, EventArgs e)
        {
            Excel.Application exceldosya = new Excel.Application();
            exceldosya.Visible = true;
            object Missing = Type.Missing;
            Excel.Workbook calismakitabi = exceldosya.Workbooks.Add(Missing);
            Excel.Worksheet sheet1 = (Excel.Worksheet)calismakitabi.Sheets[1];
            int satir = 1;
            int sutun = 1;
            int toplam = 0;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Excel.Range myrange = (Excel.Range)sheet1.Cells[satir, sutun + j];
                myrange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            satir++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Excel.Range myrange = (Excel.Range)sheet1.Cells[satir + i, sutun + j];
                    myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myrange.Select();
                }
            }
        }








    }
}

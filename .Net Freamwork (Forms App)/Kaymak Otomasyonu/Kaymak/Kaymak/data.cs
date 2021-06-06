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
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");

        private void data_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            listele();

        }
        public void listele()
        {
            baglanti.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT ID , ADI , SOYADI , MAGZA_ADI , FIYAT ,ADET ,KG , TUTAR ,  TARIH , ADRES , TELNO FROM tbl_kaymak ORDER BY TARIH , MAGZA_ADI ASC", baglanti);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            dataGridView1.DataSource = dset.Tables[0];
            baglanti.Close();
        }

        public void kalan_listele()
        {
            baglanti.Open();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter("SELECT MAGZA_ADI ,ADI , sum(KALAN) AS TOTAL_KALAN FROM tbl_kaymak WHERE ADI LIKE '%" + textBox1.Text + "%' AND SOYADI LIKE '%" + textBox2.Text + "%'  AND MAGZA_ADI LIKE '%" + textBox3.Text + "%' ORDER BY TARIH ASC", baglanti);
            DataSet dset2 = new DataSet();
            adapter2.Fill(dset2, "info");
            dataGridView2.DataSource = dset2.Tables[0];
            baglanti.Close();

        }


        private void Btn_Excel_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (textBox3.Text == "")
            {
                MessageBox.Show("LÜTFEN GEÇERLİ BİR MAĞZA ADI GİRİNİZ", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = new DataTable();

                baglanti.Open();
                SQLiteDataAdapter search = new SQLiteDataAdapter("SELECT TARIH , MAGZA_ADI , ADI , SOYADI , FIYAT , ADET , KG , TUTAR , VERILEN , KALAN FROM tbl_kaymak WHERE ADI LIKE '%" + textBox1.Text + "%' AND SOYADI LIKE '%" + textBox2.Text + "%'  AND MAGZA_ADI LIKE '%" + textBox3.Text + "%' ORDER BY TARIH ASC", baglanti);
                search.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();

                kalan_listele();
                
                this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
                this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Gray;
                this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 12);

                DataGridViewCellStyle ColumnRenk;
                dataGridView2.EnableHeadersVisualStyles = false;
                dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                ColumnRenk = dataGridView2.Columns[0].HeaderCell.Style;
                ColumnRenk.BackColor = Color.LightGreen;
                ColumnRenk = dataGridView2.Columns[1].HeaderCell.Style;
                ColumnRenk.BackColor = Color.CadetBlue;
                ColumnRenk = dataGridView2.Columns[2].HeaderCell.Style;
                ColumnRenk.BackColor = Color.Red;


            }


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

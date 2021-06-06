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
namespace FrmLogin
{
    public partial class FrmArayuz : Form
    {
        public FrmArayuz()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Resim Dosyaları |*.png";
            dialog.ShowDialog();
            txt_image.Text = dialog.FileName;
            pictureBox1.ImageLocation = txt_image.Text;

        }

        sqlitebaglanti bgl = new sqlitebaglanti();
        void listele()
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            DataTable dt = new DataTable();
            SQLiteDataAdapter dp = new SQLiteDataAdapter("SELECT ID , ADI , SOYADI , MEVKI , MAAS , AVANS , G_G_S AS GELMEDİĞİ_GÜN_S , TOTAL , IMAGE , TARIH FROM Personel", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void aktarmevki()
        {
            mevki.Items.Clear();
            SQLiteCommand cmd = new SQLiteCommand("SELECT MEVKI FROM Tbl_Mevki", bgl.baglanti());
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                mevki.Items.Add(dr[0]);

            }


        }

        void isimaktar()
        {
            adi_txt.Items.Clear();
            SQLiteCommand isim = new SQLiteCommand("SELECT DISTINCT(ADI) FROM Personel", bgl.baglanti());
            SQLiteDataReader dr = isim.ExecuteReader();
            while (dr.Read())
            {
                adi_txt.Items.Add(dr[0]);
            }



        }

        void soyisimaktar()
        {

            soyadi.Items.Clear();
            SQLiteCommand isim = new SQLiteCommand("SELECT DISTINCT(SOYADI) FROM Personel", bgl.baglanti());
            SQLiteDataReader dr = isim.ExecuteReader();
            while (dr.Read())
            {
                soyadi.Items.Add(dr[0]);
            }


        }
        private void FrmArayuz_Load(object sender, EventArgs e)
        {
            listele();
            aktarmevki();
            isimaktar();
            soyisimaktar();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (total.Text == "" || maas.Text == "")
            {
                MessageBox.Show("Eksik Tuşlama", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SQLiteCommand cmd = new SQLiteCommand("insert into Personel(ADI , SOYADI , MEVKI , MAAS , AVANS , G_G_S , TOTAL , IMAGE , TARIH) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", adi_txt.Text);
                cmd.Parameters.AddWithValue("@p2", soyadi.Text);
                cmd.Parameters.AddWithValue("@p3", mevki.Text);
                cmd.Parameters.AddWithValue("@p4", maas.Text);
                cmd.Parameters.AddWithValue("@p5", avans.Text);
                cmd.Parameters.AddWithValue("@p6", ggs.Text);
                cmd.Parameters.AddWithValue("@p7", total.Text);
                cmd.Parameters.AddWithValue("@p8", txt_image.Text);
                cmd.Parameters.AddWithValue("@p9", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                moneyler();


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adi_txt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mevki.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            avans.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            ggs.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_image.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            pictureBox1.ImageLocation = txt_image.Text;
            total.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Eksik Tuşlama", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SQLiteCommand delete = new SQLiteCommand("DELETE FROM PERSONEL WHERE ID = @p1", bgl.baglanti());
                delete.Parameters.AddWithValue("@p1", textBox1.Text);
                delete.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
        private void mevki_MouseHover(object sender, EventArgs e)
        {
            mevki.Text = "";
        }

        private void adi_txt_MouseHover(object sender, EventArgs e)
        {
            adi_txt.Text = "";
        }

        private void soyadi_MouseHover(object sender, EventArgs e)
        {
            soyadi.Text = "";
        }



        private void maas_MouseHover(object sender, EventArgs e)
        {
            maas.Text = "";
        }

        private void avans_MouseHover(object sender, EventArgs e)
        {
            avans.Text = "";
        }

        private void ggs_MouseHover(object sender, EventArgs e)
        {
            ggs.Text = "";
        }

        private void total_MouseHover(object sender, EventArgs e)
        {
            total.Text = "";
        }

        private void mevki_MouseHover_1(object sender, EventArgs e)
        {
            mevki.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (total.Text == "" || maas.Text == "")
            {
                MessageBox.Show("Eksik Tuşlama", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SQLiteCommand update = new SQLiteCommand("Update Personel Set ADI = @p1 , SOYADI = @p2 , MEVKI = @p3  , MAAS = @p4 , AVANS = @p5 , G_G_S = @p6 , TOTAL = @p7 , IMAGE = @p8 , TARIH = @p9 WHERE ID = @id", bgl.baglanti());
                update.Parameters.AddWithValue("@p1", adi_txt.Text);
                update.Parameters.AddWithValue("@p2", soyadi.Text);
                update.Parameters.AddWithValue("@p3", mevki.Text);
                update.Parameters.AddWithValue("@p4", maas.Text);
                update.Parameters.AddWithValue("@p5", avans.Text);
                update.Parameters.AddWithValue("@p6", ggs.Text);
                update.Parameters.AddWithValue("@p7", total.Text);
                update.Parameters.AddWithValue("@p8", txt_image.Text);
                update.Parameters.AddWithValue("@p9", maskedTextBox1.Text);
                update.Parameters.AddWithValue("@id", textBox1.Text);
                update.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();


            }
        }

        void moneyler()
        {
            try
            {
                double maasgir = double.Parse(maas.Text);
                double avansgir = double.Parse(avans.Text);
                double ggsgir = double.Parse(ggs.Text);
                double a = maasgir / 24; //83,33
                double total1 = maasgir - avansgir; // 2000 - 500 = 1500
                double total2 = a * ggsgir; // 83,33 * 3 = 249,99
                double total3 = total1 - total2; // 1500 - 249,99 
                total.Text = total3 + " TL";

            }

            catch (Exception)
            {

                MessageBox.Show("Hata", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void total_Click(object sender, EventArgs e)
        {
            moneyler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMevki frm = new FrmMevki();
            frm.Show();
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            adi_txt.Text = "";
            soyadi.Text = "";
            mevki.Text = "";
            maas.Text = "";
            avans.Text = "";
            ggs.Text = "";
            total.Text = "";
            textBox1.Text = "";
            txt_image.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmGrafik grf = new FrmGrafik();
            grf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Excel.Application exceldosya = new Excel.Application();
            exceldosya.Visible = true;
            object Missing = Type.Missing;
            Excel.Workbook calismakitabi = exceldosya.Workbooks.Add(Missing);
            Excel.Worksheet sheet1 = (Excel.Worksheet)calismakitabi.Sheets[1];
            int satir = 1;
            int sutun = 1;
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

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAra ara = new FrmAra();
            ara.Show();
        }

        private void adi_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                adi_txt.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            if (e.KeyCode == Keys.Q)
            {
                adi_txt.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                soyadi.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            if (e.KeyCode == Keys.Q)
            {
                soyadi.DropDownStyle = ComboBoxStyle.DropDown;
            }

        }
    }
}

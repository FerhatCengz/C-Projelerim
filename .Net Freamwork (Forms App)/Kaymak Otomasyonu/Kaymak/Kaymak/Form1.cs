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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");

        public void listele()
        {
            baglanti.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT ID , ADI , SOYADI , MAGZA_ADI , FIYAT ,ADET , KG , TUTAR , VERILEN, KALAN , TARIH , ADRES , TELNO FROM tbl_kaymak ORDER BY TARIH ASC", baglanti);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            dataGridView1.DataSource = dset.Tables[0];
            baglanti.Close();

        }

        public void datagrdsettrng(DataGridView datagrd)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            text_total.Text = "";
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            listele();
            ZEROO zro = new ZEROO();
            text_adet.Text = zro.ATAMA.ToString();
            text_kg.Text = zro.ATAMA.ToString();
            text_satis.Text = zro.ATAMA.ToString();

            text_verilen.Text = zro.ATAMA.ToString();

            averilen = double.Parse(text_verilen.Text);

        }
        private void Btn_Onay_Click(object sender, EventArgs e)
        {

            char search = 'ı';
            char search2 = 'İ';
            char search3 = 'ğ';
            char search4 = 'Ğ';
            char search5 = 'ö';
            char search6 = 'Ö';
            char search7 = 'Ü';
            char search8 = 'ü';
            char search9 = 'ü';
            char search10 = 'ş';
            char search11 = 'Ş';
            char search12 = 'ç';
            char search13 = 'Ç';
            string kelime = txt_magza.Text;
            string hece = text_adı.Text;
            foreach (var item in kelime + hece)
            {
                if (item == search || item == search2 || item == search3 || item == search4 || item == search5 || item == search6 || item == search7 || item == search8 || item == search9 || item == search10 || item == search11 || item == search12 || item == search13)
                {
                    text_total.Text = "";
                    MessageBox.Show("LÜTFEN YAZILARINIZDA\n ı Harfi \n İ Harfi \n ğ Harfi \n Ğ Harfi \n ö Harfi \n Ö Harfi \n ü Harfi \n Ü Harfi \n ş Harfi \n Ş Harfi \n ç Harfi \n Ç harfi \n  KULLANMAYINIZ !! \n\n\n\n - ÖZELLİK İLE -\n I yerine i \n İ yerine I \n Ü yerine u \n Ş yerine s \n Ç yerine c \n Ğ yerine g \n Kullanınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }


            if (text_total.Text == "" && text_adı.Text == "" && text_soyadı.Text == "" && txt_magza.Text == "")
            {
                MessageBox.Show("Kayıt Başarısız Eksik Ve ya Hatalı Tuşlama", "! HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_total.Text == "")
            {
                MessageBox.Show("TUTAR MİKTARI BOŞ BIRAKILAMAZ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                baglanti.Open();
                SQLiteCommand insert = new SQLiteCommand("insert into tbl_kaymak(ADI,SOYADI,MAGZA_ADI,FIYAT,ADET,TARIH,ADRES,TELNO,TUTAR,KG,VERILEN,KALAN) VALUES(@ad,@soyad,@mgza,@fiyat,@adet,@tarih,@adres,@telno,@tutar,@kg,@al,@kalan)", baglanti);
                insert.Parameters.AddWithValue("@ad", text_adı.Text);
                insert.Parameters.AddWithValue("@soyad", text_soyadı.Text);
                insert.Parameters.AddWithValue("@mgza", txt_magza.Text);
                insert.Parameters.AddWithValue("@fiyat", text_satis.Text);
                insert.Parameters.AddWithValue("@adet", text_adet.Text);
                insert.Parameters.AddWithValue("@tarih", date_satis.Value);
                insert.Parameters.AddWithValue("@adres", text_Adres.Text);
                insert.Parameters.AddWithValue("@telno", masked_tel.Text);
                insert.Parameters.AddWithValue("@tutar", text_total.Text);
                insert.Parameters.AddWithValue("@kg", text_kg.Text);
                insert.Parameters.AddWithValue("@al", text_verilen.Text);
                insert.Parameters.AddWithValue("@kalan", text_kalan.Text);
                tutar();

                insert.ExecuteNonQuery();
                baglanti.Close();
                text_total.Text = "";
                MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {



            if (ıd_text.Text == "")
            {
                MessageBox.Show("SİLENECEK KULLANICI BULUNAMADI", "! HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();

            }

            else
            {
                baglanti.Open();
                SQLiteCommand delete = new SQLiteCommand("Delete From tbl_kaymak Where ID = @id", baglanti);
                delete.Parameters.AddWithValue("@id", ıd_text.Text);
                delete.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ıd_text.Text = "";
                text_adı.Text = "";
                text_soyadı.Text = "";
                txt_magza.Text = "";
                text_satis.Text = "";
                text_Adres.Text = "";
                text_adet.Text = "";
                masked_tel.Clear();
                listele();
            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ıd_text.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            text_adı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            text_soyadı.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_magza.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            text_satis.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            text_adet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            text_kg.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            text_verilen.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            date_satis.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            text_Adres.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            masked_tel.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            char search = 'ı';
            char search2 = 'İ';
            char search3 = 'ğ';
            char search4 = 'Ğ';
            char search5 = 'ö';
            char search6 = 'Ö';
            char search7 = 'Ü';
            char search8 = 'ü';
            char search9 = 'ü';
            char search10 = 'ş';
            char search11 = 'Ş';
            char search12 = 'ç';
            char search13 = 'Ç';
            string kelime = txt_magza.Text;
            string hece = text_adı.Text;
            foreach (var item in kelime + hece)
            {
                if (item == search || item == search2 || item == search3 || item == search4 || item == search5 || item == search6 || item == search7 || item == search8 || item == search9 || item == search10 || item == search11 || item == search12 || item == search13)
                {
                    MessageBox.Show("LÜTFEN YAZILARINIZDA\n ı Harfi \n İ Harfi \n ğ Harfi \n Ğ Harfi \n ö Harfi \n Ö Harfi \n ü Harfi \n Ü Harfi \n ş Harfi \n Ş Harfi \n ç Harfi \n Ç harfi \n  KULLANMAYINIZ !! \n\n\n\n - ÖZELLİK İLE -\n I yerine i \n İ yerine I \n Ü yerine u \n Ş yerine s \n Ç yerine c \n Ğ yerine g \n Kullanınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_total.Text = "";
                }
            }





            if (ıd_text.Text == "")
            {
                MessageBox.Show("KULLANICI BULUNAMADI", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (text_total.Text == "")
            {
                MessageBox.Show("TUTAR MİKTARI BOŞ BIRAKILAMAZ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                baglanti.Open();
                SQLiteCommand guncelle = new SQLiteCommand("Update tbl_kaymak Set ADI = @k1 , SOYADI = @k2 , MAGZA_ADI = @k3 , FIYAT = @k4 , ADET = @k5 , TARIH = @k6 , ADRES = @k7 , TELNO = @k8 , TUTAR = @k22 , KG = @kg  , VERILEN =@al, KALAN = @kalann Where ID = @k9", baglanti);
                guncelle.Parameters.AddWithValue("@k1", text_adı.Text);
                guncelle.Parameters.AddWithValue("@k2", text_soyadı.Text);
                guncelle.Parameters.AddWithValue("@k3", txt_magza.Text);
                guncelle.Parameters.AddWithValue("@k4", text_satis.Text);
                guncelle.Parameters.AddWithValue("@k5", text_adet.Text);
                guncelle.Parameters.AddWithValue("@k6", date_satis.Value);
                guncelle.Parameters.AddWithValue("@k7", text_Adres.Text);
                guncelle.Parameters.AddWithValue("@k8", masked_tel.Text);
                guncelle.Parameters.AddWithValue("@k22", text_total.Text);
                guncelle.Parameters.AddWithValue("@kg", text_kg.Text);
                guncelle.Parameters.AddWithValue("@al", text_verilen.Text);
                guncelle.Parameters.AddWithValue("@kalann", text_verilen.Text);
                guncelle.Parameters.AddWithValue("@k9", ıd_text.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
            }
        }

        private void Btn_Clone_Click(object sender, EventArgs e)
        {
            ıd_text.Text = "";
            text_adı.Text = "";
            text_soyadı.Text = "";
            txt_magza.Text = "";
            text_satis.Text = "0";
            text_Adres.Text = "";
            text_adet.Text = "0";
            text_kg.Text = "0";
            masked_tel.Clear();
            text_total.Text = "";
            text_kalan.Text = "";
            text_verilen.Text = "0";
            text_satis.Visible = true;
            text_adet.Visible = true;
            text_kg.Visible = true;
            label8.Visible = true;
            label2.Visible = true;


        }

        private void Btn_Grafc_Click(object sender, EventArgs e)
        {
            Grafik grfk = new Grafik();
            grfk.Show();
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

        private void Btn_sırala_Click(object sender, EventArgs e)
        {
            Filitre fltr = new Filitre();
            fltr.Show();
        }


        class ZEROO
        {
            int sıfırla;
            public int ATAMA
            {
                get { return sıfırla; }
                set { sıfırla = value; }
            }
            public ZEROO()
            {
                sıfırla = 0;
            }



        }


        double satis = 0;
        double adeet = 0;
        double kg = 0;
        double total = 0;
        double total2 = 0;
        double averilen = 0;
        double hsp = 0;
        double kalan = 0;
        double kalan2 = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            tutar();






        }



        public void tutar()
        {
            if (text_kg.Text == "0")
            {
                satis = double.Parse(text_satis.Text);
                adeet = double.Parse(text_adet.Text);
                total = satis * adeet;
                text_total.Text = total.ToString() + " TL";


            }

            hsp = total;
            averilen = double.Parse(text_verilen.Text);

            if (text_adet.Text == "0")
            {
                satis = double.Parse(text_satis.Text);
                kg = double.Parse(text_kg.Text);
                total2 = satis * kg;
                text_total.Text = total2.ToString();
                text_kalan.Text = text_total.Text;
                double convert = double.Parse(text_kalan.Text);
                text_kalan.Text = (convert - averilen).ToString() + " TL";
                text_total.Text = total2.ToString() + " TL";
            }

            if (text_kg.Text == "0")
            {
                kalan = hsp - averilen;
                text_kalan.Text = kalan.ToString() + " TL";
            }

            if (text_satis.Text == "0" && text_adet.Text == "0" && text_kg.Text == "0")
            {
                text_kalan.Text = text_verilen.Text;
            }
            if (text_verilen.Text == "0" || text_verilen.Text == "")
            {
                text_kalan.Text = "0";


            }




        }

        private void hesapMakinasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void programSürümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10.01.01", "Sürüm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program © Ferhat Cengiz Tarafından Yapılmıştır", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data datta = new data();
            datta.Show();
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_satis.Text = "0";
            text_adet.Text = "0";
            text_kg.Text = "0";
            text_verilen.Text = "0";
            text_kalan.Text = "0";
            text_total.Text = "0";
            text_satis.Visible = false;
            text_adet.Visible = false;
            text_kg.Visible = false;
            label8.Visible = false;
            label2.Visible = false;
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notlarim not = new Notlarim();
            not.Show();
        }
    }
}



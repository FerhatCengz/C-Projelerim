using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Acsses_Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\User\OneDrive\Masaüstü\ACCESS VERİ TABANI\Kitaplik.mdb");
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dp = new OleDbDataAdapter("SELECT * FROM Kitaplar", baglanti);
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmb = new OleDbCommand("SELECT DISTINCT(Tur) From Kitaplar ", baglanti);
            OleDbDataReader drcmb = cmb.ExecuteReader();
            while (drcmb.Read())
            {
                cmb_tur.Items.Add(drcmb[0]);
            }


            baglanti.Close();

            listele();
        }
        string durum = "";
        private void btn_kaydet_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            OleDbCommand insert = new OleDbCommand("insert into Kitaplar(KitapAd , Yazar , Tur , Sayfa , Durum) Values(@p1 , @p2 , @p3 , @p4 , @p5 )", baglanti);
            insert.Parameters.AddWithValue("@p1", text_ad.Text);
            insert.Parameters.AddWithValue("@p2", text_yazar.Text);
            insert.Parameters.AddWithValue("@p3", cmb_tur.Text);
            insert.Parameters.AddWithValue("@p4", text_sayfa.Text);
            insert.Parameters.AddWithValue("@p5", durum);
            insert.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydedildi");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            text_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            text_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            text_yazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            text_sayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_tur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radio_s.Checked = true;
            }
            else
            {
                radio_k.Checked = true;
            }
        



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand delete = new OleDbCommand("DELETE FROM Kitaplar Where KitapID = @p1", baglanti);
            delete.Parameters.AddWithValue("@p1", text_id.Text);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            listele();
        }

        private void radio_k_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radio_s_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand update = new OleDbCommand("Update Kitaplar Set KitapAd = @p1 , Yazar = @p2 , Tur = @p3 , Sayfa = @p4 , Durum = @p5 Where KitapID = @id ", baglanti);
            update.Parameters.AddWithValue("@p1", text_ad.Text);
            update.Parameters.AddWithValue("@p2", text_yazar.Text);
            update.Parameters.AddWithValue("@p3", cmb_tur.Text);
            update.Parameters.AddWithValue("@p4", text_sayfa.Text);
            update.Parameters.AddWithValue("@p5", durum);
            update.Parameters.AddWithValue("@p6" ,text_id.Text);
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1.  
            //OleDbCommand bul = new OleDbCommand("SELECT * FROM Kitaplar Where KitapAd = @p1",baglanti);
            //bul.Parameters.AddWithValue("@p1",text_search.Text);
            //DataTable table = new DataTable();
            //OleDbDataAdapter adp = new OleDbDataAdapter(bul);
            //adp.Fill(table);
            //dataGridView1.DataSource = table;



            
            OleDbCommand search = new OleDbCommand("SELECT * FROM Kitaplar Where KitapAd LIKE '%" + text_search.Text + "%' ", baglanti);
            DataTable table = new DataTable();
            OleDbDataAdapter dp3 = new OleDbDataAdapter(search);
            dp3.Fill(table);
            dataGridView1.DataSource = table;



        }

        private void cmb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\User\OneDrive\Masaüstü\ACCESS VERİ TABANI\Kitaplik.mdb"
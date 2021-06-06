using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Okul
{
    public partial class FrmOgrenci_islem : Form
    {
        public FrmOgrenci_islem()
        {
            InitializeComponent();
        }


        Sqlbaglanti bgl = new Sqlbaglanti();

        void listele()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT Og_ID , Og_Ad , Og_SoyAd ,B.Kulup_Adi , Ogr_Cinsiyet  FROM Tbl_Ogrenciler A JOIN Tbl_Kulupler B ON B.Kulup_ID = A.Ogr_Kulup", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void FrmOgrenci_islem_Load(object sender, EventArgs e)
        {
            SqlCommand kulup = new SqlCommand("SELECT DISTINCT(CONVERT(varchar , B.Og_ID) +' - )'+ A.Kulup_Adi) FROM Tbl_Kulupler A JOIN Tbl_Ogrenciler B ON B.Ogr_Kulup = A.Kulup_ID" ,bgl.baglanti());
            SqlDataReader dr = kulup.ExecuteReader();
            while (dr.Read())
            {
                text_kulup.Items.Add(dr[0]);
            }



            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Ogrenciler(Og_Ad , Og_Soyad , Ogr_Kulup  , Ogr_Cinsiyet) Values(@p1 , @p2 ,@p3 ,@p4)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", text_ad.Text);
            cmd.Parameters.AddWithValue("@p2", text_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", text_kulup.Text);
            cmd.Parameters.AddWithValue("@p4", text_cinsiyet.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi");
            listele();
        }


















        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Ogrenciler Where Og_ID =@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", text_id.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            text_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            text_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            text_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            text_kulup.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            text_cinsiyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("Update Tbl_Ogrenciler Set Og_Ad = @p1 , Og_Soyad = @p2 , Ogr_Kulup =@p3 , Ogr_Cinsiyet = @p4 Where Og_ID = @id", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", text_ad.Text);
            cmd.Parameters.AddWithValue("@p2", text_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", text_kulup.Text);
            cmd.Parameters.AddWithValue("@p4", text_cinsiyet.Text);
            cmd.Parameters.AddWithValue("@id", text_id.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi");
            listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("SELECT Og_ID AS ID ,Og_Ad As Ad , Og_Soyad As Soyad  , Ogr_Kulup As Kulüp , Ogr_Cinsiyet As Cinsiyet FROM Tbl_Ogrenciler Where Og_Ad LIKE '%" + text_search.Text + "%'", bgl.baglanti());

            SqlDataAdapter dp2 = new SqlDataAdapter(ara);
            DataTable dt2 = new DataTable();
            dp2.Fill(dt2);
            dataGridView1.DataSource = dt2;


        }
    }
}

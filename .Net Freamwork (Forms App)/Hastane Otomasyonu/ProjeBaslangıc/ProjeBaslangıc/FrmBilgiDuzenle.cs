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
namespace ProjeBaslangıc
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            text_tc.Text = tc;
            SqlCommand aktar = new SqlCommand("SELECT * FROM Tbl_Hastalar Where HastaTC = @p1 " , bgl.baglanti());
            aktar.Parameters.AddWithValue("@p1" , text_tc.Text);
            SqlDataReader dr = aktar.ExecuteReader();
            while (dr.Read())
            {
                text_ad.Text = dr[1].ToString();
                text_soyad.Text = dr[6].ToString();
                text_tc.Text = dr[2].ToString();
                text_tel.Text = dr[3].ToString();
                text_parola.Text = dr[4].ToString();
                text_cinsiyet.Text = dr[5].ToString();


            }

            bgl.baglanti().Close();

        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar Set HastaAd = @p1 , HastaSoyad = @p6 , HastaTC = @p2 , HastaTelefon = @p3 , HastaSifre = @p4 , HastaCinsiyet = @p5  Where HastaTC = @tc", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",text_ad.Text);
            komut.Parameters.AddWithValue("@p6",text_soyad.Text);
            komut.Parameters.AddWithValue("@p2", text_tc.Text);
            komut.Parameters.AddWithValue("@p3", text_tel.Text);
            komut.Parameters.AddWithValue("@p4", text_parola.Text);
            komut.Parameters.AddWithValue("@p5", text_cinsiyet.Text);
            komut.Parameters.AddWithValue("@tc" , text_tc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");



        }
    }
}

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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            text_tc.Text = tc;



            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Doktorlar Where DoktorTC = " + text_tc.Text, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                text_ad.Text = dr[1].ToString();
                text_soyad.Text = dr[2].ToString();
                text_brans.Text = dr[3].ToString();
                text_parola.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Doktorlar Set DoktarAd = @p1 , DoktorSoyad = @p2 , DoktorBrans = @p3 ,  DoktorSifre = @p4 Where DoktorTC = " + text_tc.Text, bgl.baglanti());
            update.Parameters.AddWithValue("@p1", text_ad.Text);
            update.Parameters.AddWithValue("@p2", text_soyad.Text);
            update.Parameters.AddWithValue("@p3", text_brans.Text);
            update.Parameters.AddWithValue("@p4", text_parola.Text);
            update.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");

        }
    }
}

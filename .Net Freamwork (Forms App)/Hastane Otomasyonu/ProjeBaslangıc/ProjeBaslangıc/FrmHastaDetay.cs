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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            // AD SOYAD ÇEKME
            lbl_tc.Text = tc.ToString();
            SqlCommand komut = new SqlCommand("SELECT HastaAd , HastaSoyad From Tbl_Hastalar Where HastaTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_soyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            // RANDEVU ÇEKME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular Where HastaTC = " + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çek

            SqlCommand komut2 = new SqlCommand("SELECT BrasAd FROM Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT DoktarAd , DoktorSoyAd From Tbl_Doktorlar Where DoktorBrans = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }



        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter dp4 = new SqlDataAdapter("SELECT * FROM Tbl_Randevular Where RandevuBrans = '" + cmb_brans.Text + "'" + " and RandevuDoktor = '" + cmb_doktor.Text + "' and RandevuDurum = 0", bgl.baglanti());
            dp4.Fill(dt4);
            dataGridView2.DataSource = dt4;
        }

        private void link_bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tc = lbl_tc.Text;
            fr.Show();

        }

        private void btn_randeval_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Randevular Set RandevuDurum = 1 , HastaTC = @p1 , HastaSikayet = @p2 Where RandevuID = @p3", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", lbl_tc.Text);
            guncelle.Parameters.AddWithValue("@p2" , rch_sikayet.Text);
            guncelle.Parameters.AddWithValue("@p3",txt_id.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı" , "Uyarı" ,MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}

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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        public string adsoyad;




        public string id;
        public string Tarih;
        public string Saat;
        public string Brans;
        public string Doktor;
        public string TC;

        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {

            





            lbl_tc.Text = tc;

            // AD SOYAD EKLE
            SqlCommand komut = new SqlCommand("SELECT SekreterAdSoyad From Tbl_Sekreter Where SekreterTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0].ToString();
            }

            bgl.baglanti().Close();

            //BRANS AKTAR

            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * From Tbl_Brans", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktorları listeye aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter dp2 = new SqlDataAdapter("SELECT (DoktarAd + ' ' + DoktorSoyad)AS Doktorlar , DoktorBrans FROM Tbl_Doktorlar", bgl.baglanti());
            dp2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Brans Combox
            SqlCommand cmd = new SqlCommand("SELECT BrasAd FROM Tbl_Brans", bgl.baglanti());
            SqlDataReader drcmd = cmd.ExecuteReader();
            while (drcmd.Read())
            {
                cmb_brans.Items.Add(drcmd[0]);
            }


         

        }



        private void btn_kayiet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih , RandevuSaat , RandevuBrans , RandevuDoktor ) Values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msk_tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msk_saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komutdoktora = new SqlCommand("SELECT DoktarAd ,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans = @p1", bgl.baglanti());
            komutdoktora.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader drdoktor = komutdoktora.ExecuteReader();
            while (drdoktor.Read())
            {
                cmb_doktor.Items.Add(drdoktor[0] + " " + drdoktor[1]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand duyuru = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) Values(@p1)", bgl.baglanti());
            duyuru.Parameters.AddWithValue("@p1", rich_duyuru.Text);
            duyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Başarılı Bir Şekilde Gönderilidi");
            rich_duyuru.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBransPanel frm = new FrmBransPanel();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDuyurular d = new FrmDuyurular();
            d.Show();
        }
    }
}

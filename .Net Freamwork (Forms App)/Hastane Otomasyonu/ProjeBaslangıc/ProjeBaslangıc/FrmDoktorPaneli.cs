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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        //public void listele()
        //{
        //    DataTable table = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tbl_Doktorlar", bgl.baglanti());
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = adapter;

        //}


        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * From Tbl_Doktorlar ", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand brans = new SqlCommand("Select BrasAd From Tbl_Brans ", bgl.baglanti());
            SqlDataReader dr2 = brans.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Doktorlar(DoktarAd , DoktorSoyad , DoktorBrans , DoktorTC , DoktorSifre) Values(@p1,@p2,@p3,@p4,@p5)  ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
            cmd.Parameters.AddWithValue("@p2", text_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_brans.Text);
            cmd.Parameters.AddWithValue("@p4", msk_tc.Text);
            cmd.Parameters.AddWithValue("@p5", txt_parola.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti");

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            text_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_parola.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTC = @p1", bgl.baglanti());
            delete.Parameters.AddWithValue("@p1",msk_tc.Text);
            delete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılır");

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Doktorlar Set DoktarAd = @p1 , DoktorSoyad = @p2 , DoktorBrans = @p3 , DoktorTC = @p4 , DoktorSifre = @p5 Where DoktorTC = @tc" ,bgl.baglanti());
            update.Parameters.AddWithValue("@p1",txt_ad.Text);
            update.Parameters.AddWithValue("@p2",text_soyad.Text);
            update.Parameters.AddWithValue("@p3" , cmb_brans.Text);
            update.Parameters.AddWithValue("@p4", msk_tc.Text);
            update.Parameters.AddWithValue("@p5",txt_parola.Text);
            update.Parameters.AddWithValue("@tc",msk_tc.Text);
            update.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}

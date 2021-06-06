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
    public partial class FrmBransPanel : Form
    {
        public FrmBransPanel()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmBransPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM Tbl_Brans", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert Into Tbl_Brans(BrasAd) Values(@p1)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", cmb_brans.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarlıyla Eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_bransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("Delete From Tbl_Brans Where BransId = @p1", bgl.baglanti());
            delete.Parameters.AddWithValue("@p1", txt_bransid.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("Brans Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Brans Set BrasAd = @p1 Where BransId = @id",bgl.baglanti());
            update.Parameters.AddWithValue("@p1", cmb_brans.Text);
            update.Parameters.AddWithValue("@id", txt_bransid.Text);
            update.ExecuteReader();
            MessageBox.Show("Silme İşlemi Başarılı");

        }
    }
}

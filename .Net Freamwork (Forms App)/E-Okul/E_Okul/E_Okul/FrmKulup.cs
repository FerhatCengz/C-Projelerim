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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Tbl_Kulupler" , bgl.baglanti());
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand("insert into Tbl_Kulupler (Kulup_Adi) Values(@p1)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1", textBox2.Text);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kulup Başarıyla Eklendi");
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Kulup Adı 30 Karakterden Fazla Olamaz");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand update = new SqlCommand("Update Tbl_Kulupler Set Kulup_Adi = @p1 Where Kulup_ID = @p2", bgl.baglanti());
                update.Parameters.AddWithValue("@p1", textBox2.Text);
                update.Parameters.AddWithValue("@p2", textBox1.Text);
                update.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Kulup Adı 30 Karakterden Fazla Olamaz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Tbl_Kulupler Where Kulup_ID = @x1",bgl.baglanti());
            delete.Parameters.AddWithValue("@x1",textBox1.Text);
            delete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgretmen ogr = new FrmOgretmen();
            ogr.Show();
            this.Hide();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }
    }
}

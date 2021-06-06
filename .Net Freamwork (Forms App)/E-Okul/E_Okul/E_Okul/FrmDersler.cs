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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        void listele()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DERSLER", bgl.baglanti());
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            listele();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox2.Text.Length > 30)
            {
                MessageBox.Show("Branş Adı Bu Kadar Uzun Olamaz");
            }

            else
            {
                SqlCommand ekle = new SqlCommand("insert into Dersler(Ders_Ad) Values(@p1)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1", textBox2.Text);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme Başarılı");
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 30)
            {
                MessageBox.Show("Branş Adı Bu Kadar Uzun Olamaz");
            }
            else
            {
                SqlCommand update = new SqlCommand("Update Dersler Set Ders_Ad = @p1 Where Ders_ID = @p2", bgl.baglanti());
                update.Parameters.AddWithValue("@p1", textBox2.Text);
                update.Parameters.AddWithValue("@p2", textBox1.Text);
                update.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Günceleme Başarılı");
                listele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Dersler Where Ders_ID = @p1",bgl.baglanti());
            delete.Parameters.AddWithValue("@p1",textBox1.Text);
            delete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme Başarılı");
            listele();
        }
    }
}

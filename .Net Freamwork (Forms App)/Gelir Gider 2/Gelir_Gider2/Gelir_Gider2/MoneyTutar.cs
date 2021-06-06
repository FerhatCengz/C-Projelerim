using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MaterialSkin.Controls;
namespace Gelir_Gider2
{
    public partial class MoneyTutar : MaterialForm
    {
        public MoneyTutar()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection(@"Data Source = C:\Veri\Hesap2.db; Version=3;");


        void listele()
        {
            baglanti.Open();
            SQLiteDataAdapter dp = new SQLiteDataAdapter("SELECT * FROM Tbl_Money", baglanti);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            baglanti.Close();
        }
        private void MoneyTutar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand insert = new SQLiteCommand("insert into Tbl_Money(MoneyTutar , MoneyTarih , MoneyStart) Values(@p1,@p2 ,@p3)", baglanti);
            insert.Parameters.AddWithValue("@p1", textBox1.Text + " TL");
            insert.Parameters.AddWithValue("@p2", dateTimePicker1.Text);
            insert.Parameters.AddWithValue("@p3", textBox1.Text);
            insert.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para Kayıta Geçti", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand insert = new SQLiteCommand("Update Tbl_Money Set MoneyTutar = @k1 , MoneyTarih = @k2 Where MoneyID = @id", baglanti);
            insert.Parameters.AddWithValue("@k1", textBox1.Text + " TL");
            insert.Parameters.AddWithValue("@k2", dateTimePicker1.Text);
            insert.Parameters.AddWithValue("@id", textBox2.Text);
            insert.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para Güncellendi ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand CMD = new SQLiteCommand("Delete From Tbl_Money Where MoneyID = @id", baglanti);
            CMD.Parameters.AddWithValue("@id", textBox2.Text);
            CMD.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Silindi ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

            baglanti.Open();
            SQLiteCommand cmdd = new SQLiteCommand("Delete From Tbl_Giderler Where Tarih = @p10",baglanti);
            cmdd.Parameters.AddWithValue("@p10",dateTimePicker1.Text);
            cmdd.ExecuteNonQuery();
            baglanti.Close();
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();

        }
    }
}

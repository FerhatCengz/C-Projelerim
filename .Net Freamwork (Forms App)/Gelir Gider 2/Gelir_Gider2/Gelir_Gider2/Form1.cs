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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection(@"Data Source = C:\Veri\Hesap2.db; Version=3;");


        void listele()
        {
            SQLiteDataAdapter dr = new SQLiteDataAdapter("SELECT * FROM Tbl_Giderler", baglanti);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

        }


        void insert()
        {


            baglanti.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into Tbl_Giderler (Adi,Money,Tarih) Values(@p1,@p2,@p3)", baglanti);
            cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p2", money_text.Text);
            cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }


        void combo()
        {

            comboBox1.Items.Clear();
            baglanti.Open();
            SQLiteCommand liteCommand = new SQLiteCommand("SELECT DISTINCT(Adi) From Tbl_Giderler LIMIT 14", baglanti);
            SQLiteDataReader dataReader = liteCommand.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);

            }

            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combo();
            listele();
            erisim();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id_text.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            money_text.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString().Replace("TL", "");
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }


        Label moneyidtutuyorum = new Label();
        void money()
        {
            comboBox2.Items.Clear();

            baglanti.Open();

            SQLiteCommand sQ = new SQLiteCommand("SELECT MoneyTutar , MoneyID From Tbl_Money  Where MoneyTarih = @tarih", baglanti);
            sQ.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
            SQLiteDataReader reader = sQ.ExecuteReader();
            while (reader.Read())
            {

                moneyidtutuyorum.Text = reader[1].ToString();

            }


            baglanti.Close();

        }


        private void erisim()
        {
            //comboBox2.Items.Clear();
            baglanti.Open();
            SQLiteCommand sQ = new SQLiteCommand("SELECT MoneyTutar FROM Tbl_Money Where MoneyTarih =@p1", baglanti);
            sQ.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SQLiteDataReader dr = sQ.ExecuteReader();

            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
            }

            baglanti.Close();

        }

        Label labeltut = new Label();
        private void button1_Click(object sender, EventArgs e) //Giriş
        {
            erisim();
            money();
            int int_lbl = 0, int_money_text = 0, int_total = 0;
            int_lbl = Convert.ToInt32(comboBox2.Text.Replace("TL", ""));
            int_money_text = Convert.ToInt32(money_text.Text);
            int_total = int_lbl - int_money_text;

            baglanti.Open();
            SQLiteCommand update2 = new SQLiteCommand("Update Tbl_Money Set MoneyTutar = @p1 Where MoneyID = @id", baglanti);
            update2.Parameters.AddWithValue("@p1", int_total + " TL");
            update2.Parameters.AddWithValue("@id", moneyidtutuyorum.Text);
            update2.ExecuteNonQuery();
            baglanti.Close();
            insert();
            listele();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labeltut.Text = comboBox2.Text.Replace("TL", "");
            button1.Enabled = true;

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            combo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
        }



        int tid = 0;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tid = 11;
            dateTimePicker2.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmGrafik frmGrafik = new FrmGrafik();
            frmGrafik.tarih = dateTimePicker2.Text;
            frmGrafik.idtarih = tid;
            frmGrafik.Show();

        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand sQ = new SQLiteCommand("Select * From Tbl_Giderler Where Tarih = @get", baglanti);
            sQ.Parameters.AddWithValue("@get", dateTimePicker2.Text);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sQ);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();


        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            tid = 4;
            dateTimePicker2.Visible = false;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoneyTutar tt = new MoneyTutar();
            tt.Show();
            this.Hide();

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            erisim();
            baglanti.Open();

            SQLiteCommand sQ = new SQLiteCommand("Select MoneyTutar From Tbl_Money Where MoneyTarih = @get", baglanti);
            sQ.Parameters.AddWithValue("@get", dateTimePicker1.Text);
            SQLiteDataReader dr = sQ.ExecuteReader();

            if (dr.Read())
            {
                comboBox2.Text = label1.Text;
                button1.Visible = true;
                labelinsert.Location = new Point(84, 19);
                labelinsert.Text = "Kaydet";

            }
            else
            {
                button1.Visible = false;
                labelinsert.Location = new Point(12, 6);
                labelinsert.Text = "Boş Tutara Veri\nGiremezsiniz";
            }

            baglanti.Close();




        }

        void deletesil()
        {
            try
            {
                money();
                erisim();

                int lbl_arti = 0, money_arti = 0, total_arti = 0;
                lbl_arti = Convert.ToInt32(label1.Text.Replace("TL", ""));
                money_arti = Convert.ToInt32(money_text.Text);
                total_arti = lbl_arti + money_arti;

                baglanti.Open();
                SQLiteCommand cmd = new SQLiteCommand("Update Tbl_Money Set MoneyTutar = @total Where MoneyID = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", moneyidtutuyorum.Text);
                cmd.Parameters.AddWithValue("@total", total_arti + " TL");
                cmd.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SQLiteCommand updates = new SQLiteCommand("Delete From Tbl_Giderler Where ID = @id", baglanti);
                updates.Parameters.AddWithValue("@id", id_text.Text);
                updates.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Girmiş Olduğunuz Alanları Tekrar Kontrol Ediniz");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            deletesil();
            panel3del.Visible = false;
            button2.Visible = false;
            label4m.Visible = false;
            progressBar1.Visible = true;
            button1.Visible = false;
            panel2.Visible = false;
            labelinsert.Visible = false;
            timer1.Start();
        }


        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            progressBar1.Value = sure;
            if (sure == 3)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                sure = 0;
                button2.Visible = true;
                label4m.Visible = true;
                panel3del.Visible = true;
                progressBar1.Visible = false;
                button1.Visible = true;
                panel2.Visible = true;
                labelinsert.Visible = true;

            }
        }

    }
}

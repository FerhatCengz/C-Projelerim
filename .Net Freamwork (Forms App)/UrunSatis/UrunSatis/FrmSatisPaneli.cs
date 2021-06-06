using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunSatis
{
    public partial class FrmSatisPaneli : Form
    {
        public FrmSatisPaneli()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        SatisMagzaEntities db = new SatisMagzaEntities();
        void listele()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = db.Tbl_SatisUrun.ToList();
        }

        private void FrmSatisPaneli_Load(object sender, EventArgs e)
        {
            var atama = db.Tbl_SatisUrun.ToList();
            textBox2.ValueMember = "URUNADI";
            textBox2.DisplayMember = "URUNADI";
            textBox2.DataSource = atama;
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }


        int arti = 0;
        int total = 0;

        private void button3_Click(object sender, EventArgs e)
        {

            int cevir = Convert.ToInt16(label3.Text);
            int cevir2 = Convert.ToInt16(lbl_money.Text);
            if (cevir < 0 || cevir == 0)
            {

                MessageBox.Show("İşlem Başarısız\nÜrün Stoğunu Kontrol Ediniz");
            }
            else if (cevir2 > cevir)
            {
                MessageBox.Show("İşlem Başarısız\nÜrün Stoğunu Kontrol Ediniz");

            }
            else
            {
                try
                {
                    total = int.Parse(label3.Text) - arti;
                    label4.Text = total.ToString();
                    var satis = db.Tbl_SatisUrun.Find(int.Parse(textBox1.Text));
                    satis.URUNSTOK = short.Parse(label4.Text);
                    db.SaveChanges();
                    MessageBox.Show("Satış Başarılı");
                    listele();
                    arti = 0;

                }
                catch (Exception)
                {

                    MessageBox.Show("ÜRÜN STOK SAYISINDAN DAHA FAZLA İNİLEMEZ");
                }

            }






        }




        private void button2_Click(object sender, EventArgs e)
        {
            arti++;
            lbl_money.Text = arti.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            arti--;
            if (arti > 0)
            {
                lbl_money.Text = arti.ToString();

            }
            else
            {
                MessageBox.Show("0'DAN AŞAĞA DEĞER ALAMASINIZ");
                lbl_money.Text = 0.ToString();
                arti = 0;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "Pantolon";
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "Kaban";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "Ceket";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "V YAKALI T-SHIRT";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "AYAKKABI";
        }
        FrmArayuz ara = new FrmArayuz();
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ara.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //arti = 0;
            lbl_money.Text = arti.ToString();
            textBox2.Text = "Gömlek";
        }
    }
}

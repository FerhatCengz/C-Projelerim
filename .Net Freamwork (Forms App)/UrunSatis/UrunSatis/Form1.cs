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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = db.Tbl_SatisUrun.ToList();
        }
        SatisMagzaEntities db = new SatisMagzaEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            var x = db.TBL_URUNEKLE.ToList();
            cmb_ad.ValueMember = "URUNADI";
            cmb_ad.DisplayMember = "URUNADI";
            cmb_ad.DataSource = x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tbl_SatisUrun satis = new Tbl_SatisUrun();
            satis.URUNADI = cmb_ad.SelectedValue.ToString();
            satis.URUNSTOK = short.Parse(textstok.Text);
            satis.URUNFIYAT = decimal.Parse(textfiyat.Text);
            db.Tbl_SatisUrun.Add(satis);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklenmiştir" , "" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            listele();
        

            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmb_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textstok.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textfiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                var x = db.Tbl_SatisUrun.Find(short.Parse(textBoxid.Text));
                x.URUNADI = cmb_ad.Text;
                x.URUNSTOK = short.Parse(textstok.Text);
                x.URUNFIYAT = decimal.Parse(textfiyat.Text);
                db.SaveChanges();
                MessageBox.Show("Başarıyla Güncellendi");
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Alanları Kontrol Ediniz");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var x = db.Tbl_SatisUrun.Find(short.Parse(textBoxid.Text));
            db.Tbl_SatisUrun.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Silindi");
            listele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "Pantolon";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "Gömlek";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "Kaban";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "Ceket";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "V YAKALI T-SHIRT";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cmb_ad.Text = "Ayakkabı";
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmArayuz ara = new FrmArayuz();
            ara.Show();
            this.Close();
        }
    }
}

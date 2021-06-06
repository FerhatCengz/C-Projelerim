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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        SatisMagzaEntities db = new SatisMagzaEntities();
        void listele()
        {
            dataGridView1.DataSource = db.TBL_URUNEKLE.ToList();
        }
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBL_URUNEKLE urun = new TBL_URUNEKLE();
            urun.URUNADI = textBox1.Text;
            db.TBL_URUNEKLE.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi", "Bilginlendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = db.TBL_URUNEKLE.Find(int.Parse(textBox2.Text));
            db.TBL_URUNEKLE.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi");
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = db.TBL_URUNEKLE.Find(int.Parse(textBox2.Text));
            x.URUNADI = textBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
            listele();
        }

        FrmArayuz ara = new FrmArayuz();
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ara.Show();
            this.Close();
        }



        private void label4_Click(object sender, EventArgs e)
        {
            ara.Show();
            this.Close();
        }


    }
}

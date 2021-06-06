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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKulup kp = new FrmKulup();
            kp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler drs = new FrmDersler();
            drs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenci_islem islem = new FrmOgrenci_islem();
            islem.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm3 = new FrmSinavNotlar();
            frm3.brans_id = id;
            frm3.Show();
            this.Hide();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();
        public string id;
        public string parola;
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand ("SELECT Ogr_AdSoyad FROM Tbl_Ogretmen Where Ogr_Brans = @p1 and Ogr_Parola = @p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2" , parola);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " Hocam";
            }

        }
    }
}

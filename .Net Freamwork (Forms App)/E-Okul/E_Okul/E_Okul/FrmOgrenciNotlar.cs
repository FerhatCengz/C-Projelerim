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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        public string numara;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            

            //DataTable dt = new DataTable();
            //SqlDataAdapter dp = new SqlDataAdapter("SELECT  * FROM Tbl_Notlar Where Ogr_ID =" + numara, bgl.baglanti());
            //dp.Fill(dt);
            //dataGridView1.DataSource = dt;

            SqlCommand cmd = new SqlCommand("SELECT Ders_Ad , A.Sinav1 , A.Sinav2, A.Sinav3, A.Proje , A.Ortalama FROM Tbl_Notlar A JOIN Dersler B ON A.Ders_ID = B.Ders_ID WHERE Ogr_ID = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dp = new DataTable();
            da.Fill(dp);
            dataGridView1.DataSource = dp;
            bgl.baglanti().Close();


            SqlCommand cmd2 = new SqlCommand("SELECT Og_Ad , Og_Soyad From Tbl_Ogrenciler Where Og_ID = @k1",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@k1",numara);
            SqlDataReader cmd2read = cmd2.ExecuteReader();
            while (cmd2read.Read())
            {
                this.Text = "Öğrenci Adı : " +  cmd2read[0] + " " + cmd2read[1];
            }
            
        }
    }
}

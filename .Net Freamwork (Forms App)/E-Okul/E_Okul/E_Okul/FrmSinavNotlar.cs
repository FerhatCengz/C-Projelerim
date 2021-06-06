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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        public string brans_id;
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            SqlCommand cmd3 = new SqlCommand("SELECT  B.Ders_Ad AS DERS, C.Og_Ad AS ADI , C.Og_SoyAd AS SOYADI , A.Sinav1 AS SINAV, A.Sinav2  AS SINAV2, A.Sinav3 AS SINAV3 , A.Proje AS PROJE , A.Ortalama AS ORTALAMA FROM Tbl_Notlar A JOIN Dersler B ON A.Ders_ID =B.Ders_ID JOIN Tbl_Ogrenciler C ON C.Og_ID = A.Ogr_ID Where B.Ders_ID = @p1", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", brans_id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}

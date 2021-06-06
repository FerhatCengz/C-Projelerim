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
namespace ProjeBaslangıc
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM Tbl_Randevular", bgl.baglanti());
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //string s_id;
        //string s_Tarih;
        //string s_Saat;
        //string s_Brans;
        //string s_Doktor;
        //string s_TC;

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    FrmSekreterDetay detay = new FrmSekreterDetay();
        //    int secilen = dataGridView1.SelectedCells[0].RowIndex;
        //    s_id = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        //    s_Tarih = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        //    s_Saat = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        //    s_Brans = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        //    s_Doktor = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        //    s_TC = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        //    detay.id = s_id;
        //    detay.Tarih = s_Tarih;
        //    detay.Saat = s_Saat;
        //    detay.Show();
        //    this.Close();
        //}
    }
}

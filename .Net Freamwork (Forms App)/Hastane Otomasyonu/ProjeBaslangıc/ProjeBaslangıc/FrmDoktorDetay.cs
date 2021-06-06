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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("SELECT DoktarAd , DoktorSoyad From Tbl_Doktorlar Where DoktorTC =" + tc, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable table = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM Tbl_Randevular Where RandevuDurum = 1 and RandevuDoktor = '" + lbladsoyad.Text + "'", bgl.baglanti());
            dp.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle bg = new FrmDoktorBilgiDuzenle();
            bg.tc = lbltc.Text;
            bg.Show();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

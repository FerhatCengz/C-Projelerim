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
namespace FrmLogin
{
    public partial class DeleteMevki : Form
    {
        public DeleteMevki()
        {
            InitializeComponent();
        }
        sqlitebaglanti bgl = new sqlitebaglanti();
        void listele()
        {
            data_grid.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            data_grid.DefaultCellStyle.ForeColor = Color.Black;
            DataTable dt = new DataTable();
            SQLiteDataAdapter dp = new SQLiteDataAdapter("SELECT * FROM Tbl_Mevki", bgl.baglanti());
            dp.Fill(dt);
            data_grid.DataSource = dt;
        }




        private void DeleteMevki_Load_1(object sender, EventArgs e)
        {
            listele();

        }

        private void data_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = data_grid.SelectedCells[0].RowIndex;
            textBox1.Text = data_grid.Rows[secilen].Cells[0].Value.ToString();
            SQLiteCommand cmd = new SQLiteCommand("Delete From Tbl_Mevki Where ID = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            listele();

        }
    }
}

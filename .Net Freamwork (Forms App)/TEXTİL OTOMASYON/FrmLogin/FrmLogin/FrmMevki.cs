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
    public partial class FrmMevki : Form
    {
        public FrmMevki()
        {
            InitializeComponent();
        }
        sqlitebaglanti bgl = new sqlitebaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("Insert Into Tbl_Mevki(MEVKI) Values(@p1)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eklenti Başarılı");
            
        }

        private void FrmMevki_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT MEVKI FROM Tbl_Mevki", bgl.baglanti());
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteMevki del = new DeleteMevki();
            del.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT MEVKI FROM Tbl_Mevki", bgl.baglanti());
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmArayuz frm = new FrmArayuz();
            frm.Show();
            this.Close();
        }
    }
}

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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand doktorgiris = new SqlCommand("SELECT * FROM Tbl_Doktorlar Where DoktorTC = @p1 and DoktorSifre = @p2", bgl.baglanti());
            doktorgiris.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            doktorgiris.Parameters.AddWithValue("@p2" , textBox1.Text);
            SqlDataReader dr = doktorgiris.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay detay = new FrmDoktorDetay();
                detay.tc = maskedTextBox1.Text;
                detay.Show();
                this.Hide();

            }
            bgl.baglanti().Close();


        }

      
    }
}

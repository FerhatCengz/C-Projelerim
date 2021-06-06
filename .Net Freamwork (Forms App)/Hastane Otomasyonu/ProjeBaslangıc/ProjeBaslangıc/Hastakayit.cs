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
    public partial class Hastakayit : Form
    {
        public Hastakayit()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand insert = new SqlCommand("insert into Tbl_Hastalar(HastaAd , HastaTC , HastaTelefon , HastaSifre , HastaCinsiyet , HastaSoyad) Values(@ad,@tc,@tel,@pass,@cinsiyet , @hasta)",bgl.baglanti());
            insert.Parameters.AddWithValue("@ad",text_ad.Text);
            insert.Parameters.AddWithValue("@tc", text_tc.Text);
            insert.Parameters.AddWithValue("@tel", text_tel.Text);
            insert.Parameters.AddWithValue("@pass", text_parola.Text);
            insert.Parameters.AddWithValue("@cinsiyet",text_cinsiyet.Text);
            insert.Parameters.AddWithValue("@hasta",text_soyad.Text);
            insert.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı \n Şifreniz : " + text_parola.Text , "Bilgi",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
    }
}

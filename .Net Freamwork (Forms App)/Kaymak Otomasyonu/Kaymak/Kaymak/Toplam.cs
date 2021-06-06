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

namespace Kaymak
{
    public partial class Toplam : Form
    {
        public Toplam()
        {
            InitializeComponent();
        }

        private void Toplam_Load(object sender, EventArgs e)
        {
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Veri\\veri2.db;Version=3;");
            baglanti.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT SUM(TUTAR) FROM tbl_kaymak", baglanti);
            label2.Text = adapter.ToString();
            baglanti.Close();



        }
    }
}

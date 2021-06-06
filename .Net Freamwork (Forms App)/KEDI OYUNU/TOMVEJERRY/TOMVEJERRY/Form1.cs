using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOMVEJERRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayaç = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                Point point = new Point();
                point.X = sayaç += 200;
                point.Y = 40;
                pictureBox1.Location = point;
                if (pictureBox1.Location.X == 600)
                {

                    DialogResult dialog = MessageBox.Show("BAŞARILI");
                    if (dialog == DialogResult.OK)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WASD VE YA OK TUŞLARI İLE KOMUT VEREBİLİRSİNİZ İYİ OYUNLAR :)");
        }
    }
}

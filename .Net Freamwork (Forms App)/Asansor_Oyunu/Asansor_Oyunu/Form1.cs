using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Asansor_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zeminkat = 0;
        int katbir = 0;
        int katiki = 0;
        int katuc = 0;
        int katdort = 0;
        private void kat1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point zemin = new Point();
            zeminkat++;
            zemin.X = 220;
            zemin.Y = 450;
            pictureBox1.Location = zemin;
            if (pictureBox1.Location == zemin)
            {
                timer1.Stop();
                MessageBox.Show("Z Katındasın");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Point birincikat = new Point();
            birincikat.X = 220;
            birincikat.Y = 366;
            pictureBox1.Location = birincikat;
            if (pictureBox1.Location == birincikat)
            {
                timer2.Stop();
                MessageBox.Show("1.Kattasın");
            }
        }

        private void kat2_Click(object sender, EventArgs e)
        {
            Point ikincikat = new Point();
            ikincikat.X = 220;
            ikincikat.Y = 295;
            pictureBox1.Location = ikincikat;
            if (pictureBox1.Location == ikincikat)
            {
                MessageBox.Show("2.Kattasın");
            }
        }

        private void kat3_Click(object sender, EventArgs e)
        {
            Point ucuncukat = new Point();
            ucuncukat.X = 220;
            ucuncukat.Y = 204;
            pictureBox1.Location = ucuncukat;
            if (pictureBox1.Location == ucuncukat)
            {
                MessageBox.Show("3.Kattasın");
            }
        }

        private void kat4_Click(object sender, EventArgs e)
        {
            Point dorduncukat = new Point();
            dorduncukat.X = 220;
            dorduncukat.Y = 137;
            pictureBox1.Location = dorduncukat;
            if (pictureBox1.Location == dorduncukat)
            {
                MessageBox.Show("4.Kattasınız");
            }
        }

        private void kat5_Click(object sender, EventArgs e)
        {
            Point besıncıkat = new Point();
            besıncıkat.X = 220;
            besıncıkat.Y = 65;
            pictureBox1.Location = besıncıkat;
            if (pictureBox1.Location == besıncıkat)
            {
                MessageBox.Show("5.Kattasınız");
            }
        }

        private void kat6_Click(object sender, EventArgs e)
        {
            Point altıncıkat = new Point();
            altıncıkat.X = 220;
            altıncıkat.Y = 5;
            pictureBox1.Location = altıncıkat;
            if (pictureBox1.Location == altıncıkat)
            {
                MessageBox.Show("6.Kattasınız");
            }
        }

        private void acilldurumdurha_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = "C:\\Users\\User\\OneDrive\\Masaüstü\\Png Resimler\\a.mp3";
            wmp.controls.play();
            kat1.Enabled = false;
            kat2.Enabled = false;
            kat3.Enabled = false;
            kat4.Enabled = false;
            kat5.Enabled = false;
            kat6.Enabled = false;
            zkat.Enabled = false;
            timer3.Start();


        }
        int sayac = 7;
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer4.Start();
            sayac--;
            label8.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer3.Stop();
                sayac = 7;
                kat1.Enabled = true;
                kat2.Enabled = true;
                kat3.Enabled = true;
                kat4.Enabled = true;
                kat5.Enabled = true;
                kat6.Enabled = true;
                zkat.Enabled = true;
                timer4.Stop();
                this.BackColor = Color.Orange;
                label8.Text = " ";
            }
            
                
                
            

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                this.BackColor = Color.Red;
            }
            else if (sayac % 2 == 1)
            {
                this.BackColor = Color.DarkRed;
            }

        }

        
    }
}

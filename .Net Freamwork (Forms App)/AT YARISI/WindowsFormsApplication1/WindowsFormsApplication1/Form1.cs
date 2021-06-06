using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void restart()
        {

            Point hourse = new Point();
            hourse.X = 118;
            hourse.Y = 28;
            pictureBox1.Location = hourse;

            Point hourse2 = new Point();
            hourse2.X = 118;
            hourse2.Y = 140;
            pictureBox2.Location = hourse2;

            Point hourse3 = new Point();
            hourse3.X = 118;
            hourse3.Y = 253;
            pictureBox3.Location = hourse3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                MessageBox.Show("Oyun Başlatılamadı\nTur Sayısı 0 ' dan Büyük Olmalı");
            }
            else
            {
                goplay();
            }
        }
        int sayac = 6;
        int tur = 0;

        public void goplay()
        {
            tur++;

            int x = 0, x2 = 0, x3 = 0;
            Random rastgele = new Random();
            x = rastgele.Next(100, 824);
            x2 = rastgele.Next(100, 824);
            x3 = rastgele.Next(100, 824);

            Point hourse = new Point();
            hourse.X = x;
            hourse.Y = 28;
            pictureBox1.Location = hourse;

            Point hourse2 = new Point();
            hourse2.X = x2;
            hourse2.Y = 140;
            pictureBox2.Location = hourse2;

            Point hourse3 = new Point();
            hourse3.X = x3;
            hourse3.Y = 253;
            pictureBox3.Location = hourse3;

            if (x > x2 && x > x3)
            {
                MessageBox.Show("Fidan Kazandı", "WİN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
                timer2.Start();
                button1.Visible = true;
                listBox1.Items.Add(tur + ".Tur Fidan");

            }
            else if (x2 > x && x2 > x3)
            {
                MessageBox.Show("Gül Kazandı", "WİN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
                timer2.Start();
                listBox1.Items.Add(tur + ".Tur Gül");

            }
            else if (x3 > x && x3 > x)
            {
                MessageBox.Show("Papatya Kazandı", "WİN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
                timer2.Start();
                listBox1.Items.Add(tur + ".Tur Papatya");

            }
            else
            {
                MessageBox.Show("BERABERE", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
                timer2.Start();
                listBox1.Items.Add(tur + ".Tur Berabere");

            }

            if (tur == bitis)
            {
                int sifir = 0;
                timer1.Start();
                timer2.Start();
                textBox1.Text = sifir.ToString();
                listBox1.Items.Clear();
                textBox1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                bitis = 0;
                tur = 0;

            }
            if (bitis == 0)
            {
                timer1.Stop();
                timer2.Stop();
                restart();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac--;
            button1.Text = ("Restart" + "(" + sayac + ")");
            if (sayac == 0)
            {
                timer1.Stop();
                restart();
                button1.Enabled = true;
                button1.Text = "Başlat";
                button1.ForeColor = Color.White;
                button1.BackColor = Color.LightGreen;

                sayac = 6;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.ForeColor = Color.Red;
            button1.BackColor = Color.DarkRed;
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sifir = 0;
            textBox1.Text = sifir.ToString();
            button3.Visible = false;
            button2.Visible = true;
        }

        int bitis = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            bitis++;
            textBox1.Text = bitis.ToString();
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitis--;
            textBox1.Text = bitis.ToString();
            if (bitis == 0)
            {
                button3.Visible = false;
            }

        }

    }
}

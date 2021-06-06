using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] cap1 = { 14, 31, 9, 22, 18, 29, 7, 28, 12 };
        int[] cap2 = { 35, 3, 26, 0, 32, 15, 19, 4, 21 };
        int[] cap3 = { 2, 25, 17, 34, 6, 27, 13, 36, 11 };
        int[] cap4 = { 30, 8, 23, 10, 5, 24, 16, 33, 1, 20 };
        int gelir;
        int gider;
        int totalkazanc;
        int totalkayıp;
        int kazanc = 0;
        int kayıp = 0;
        int girilensayi;
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label5.Enabled = false;
            label3.Visible = false;
            label3.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            girilensayi = Convert.ToInt16(textBox1.Text);
            listBox3.Items.Add(textBox1.Text);
            switch (girilensayi)
            {
                case 14:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 31:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 9:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 22:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 18:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 29:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 7:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 28:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 12:
                    foreach (var item in cap3)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;



                //ÇAP 2 ALGORİTMA :

                case 35:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 3:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 26:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 0:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;

                case 32:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 15:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 19:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 4:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 21:
                    foreach (var item in cap4)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                //ÇAP 3 : Algoritma


                case 2:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 25:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 17:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 34:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 6:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 27:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 13:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 36:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 11:
                    foreach (var item in cap1)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                //Çap 4 
                case 30:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 8:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 23:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 10:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 5:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 24:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 16:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 33:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 1:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;
                case 20:
                    foreach (var item in cap2)
                    {
                        listBox1.Items.Add(item);
                    }
                    break;


                //DEFULT 
                default:
                    listBox1.Items.Add("HATALI DEĞER GİRDİNİZ");
                    break;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label5.Visible = false;
            label5.Enabled = false;
            label3.Visible = false;
            label3.Enabled = false;
        }
        class Deger
        {
            int atama;
            int eksiatama;
            public int ATAMA
            {
                get { return atama; }
                set { atama = value; }
            }
            public Deger()
            {
                atama = 0;
                eksiatama = 0;
            }
            public int EKSIATAMA
            {
                get { return eksiatama; }
                set { eksiatama = value; }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Deger deger = new Deger();
            lost.Text = deger.ATAMA.ToString();
            won.Focus();
            button3.Enabled = false;
            listBox1.Items.Clear();
            label5.Visible = true;
            label5.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deger deger2 = new Deger();
            lost.Focus();
            won.Text = deger2.EKSIATAMA.ToString();
            button2.Enabled = false;
            listBox1.Items.Clear();
            label3.Visible = true;
            label3.Enabled = true;
            label6.Visible = true;
        }

        private void kasahesap_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label11.Visible = true;
            label13.Visible = true;


            kazanc = Convert.ToInt32(won.Text);
            kayıp = Convert.ToInt32(lost.Text);
            totalkazanc = kazanc;
            totalkayıp = kayıp;

            listBox2.Items.Add("WON : " + totalkazanc.ToString() + " TL");
            listBox2.Items.Add("LOST : " + totalkayıp.ToString() + " TL");
            gelir += totalkazanc;
            gider -= totalkayıp;
            label10.Text = "WON KAZANÇ :" + gelir.ToString();
            label11.Text = "LOST KAZANÇ :" + gider.ToString();
            int total3 = gelir + gider;
            label13.Text = total3.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }


    }
}

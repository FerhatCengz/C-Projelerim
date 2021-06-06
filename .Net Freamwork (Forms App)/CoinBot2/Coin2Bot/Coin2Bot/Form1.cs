using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinBot;
using System.Net;
namespace Coin2Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MouseEventWin32 get = new MouseEventWin32();


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X : " + MousePosition.X;
            label2.Text = "Y : " + MousePosition.Y;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            //bozdur_sat();


        }

        void sifirdanhareket_analizi()
        {
            //1419,406 
           //, 1545,407
            Cursor.Position = new Point(1429, 405);
            MouseEventWin32.SolMouseBasiliClick(1419, 406);//seçme      1473,404
            Thread.Sleep(0500);
            Cursor.Position = new Point(1545,407); //1393,411
            Thread.Sleep(0500);
            //Cursor.Position = new Point(1454, 406);
            //Thread.Sleep(1500);
            MouseEventWin32.SagMouseClick(1545,407);   //sağ tıkla
            Thread.Sleep(0500);
            MouseEventWin32.SolMouseClick(1551, 434); // 1440,420
            Thread.Sleep(0500);
            MouseEventWin32.SolMouseClick(1152, 366);
            Thread.Sleep(0500);
            MouseEventWin32.SagMouseClick(286, 322);
            Thread.Sleep(0500);
            MouseEventWin32.SolMouseClick(356, 415);
            Thread.Sleep(0500);
            MouseEventWin32.SolMouseClick(349, 305);
            Thread.Sleep(0500);
        }

        void satin_al()
        {
            double lblboz = 0;
            double alinacakyuzde = 0;
            lblboz = double.Parse(label4.Text);
            alinacakyuzde = double.Parse(text_al.Text);
            if (lblboz <= alinacakyuzde)
            {
                //1462,807        
                MouseEventWin32.SolMouseClick(1301, 575); // Eskisi 1301,575
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1716, 670);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1462, 807);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1089, 411);
                Thread.Sleep(0500);
            }

        }

        void bozdur_sat()
        {
            double lblboz2 = double.Parse(label4.Text);
            double paraboz = double.Parse(text_boz.Text);
            if (lblboz2 >= paraboz)
            {
                //1597,552   sayfa 1106,70
                MouseEventWin32.SolMouseClick(1597, 552);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1718, 671);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1462, 807);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1089, 411);
                Thread.Sleep(0500);
                MouseEventWin32.SolMouseClick(1106, 70);
                Thread.Sleep(3500);

            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(158, 177);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label4.Text = (textBox1.Text).Replace(" %", "");
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Application.Restart();
            }
            if (e.KeyCode == Keys.Q)
            {
                button2.Enabled = false;
            }
            if (e.KeyCode == Keys.X)
            {
                button2.Enabled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        int sayac = 0;
        bool kontrol = true;
        bool kontrol2 = true;
        int syclear = 0;
        bool buttonyonel = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            totalkodlarinhepsi();
        }

        private void bilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC ADI :" + Dns.GetHostName() + "\nIP Adres : " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + "\nDil : " + InputLanguage.DefaultInputLanguage.Culture.Name, "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pozisyonAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPozisyon frmPozisyon = new FrmPozisyon();
            frmPozisyon.Show();
        }



        void siteyonel()
        {
            if (comboBox1.Text == "Dogecoin")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/doge-tl");

            }
            if (comboBox1.Text == "Holo")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/hot-tl");
            }

            if (comboBox1.Text == "Bittorent")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/btt-tl");

            }
            if (comboBox1.Text == "Chiliz")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/chz-tl");


            }
            if (comboBox1.Text == "Tether")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/usdt-tl");

            }
            if (comboBox1.Text == "Ripple")
            {
                System.Diagnostics.Process.Start("https://www.paribu.com/#/easy-trade/xrp-tl");

            }
        }

        void totalkodlarinhepsi()
        {
            try
            {
                double lblkontrol = double.Parse(label4.Text);
                double coinsat_kontrol = double.Parse(text_boz.Text);
                double coinal_kontrol = double.Parse(text_al.Text);
                sayac++;
                syclear++;
                while (sayac > 3)
                {
                    sifirdanhareket_analizi();
                    break;
                    if (true)
                    {
                        sayac = 0;
                    }
                }
                if (syclear == 300000)
                {
                    listBox1.Items.Clear();
                }

                if (kontrol == true)
                {
                    if (coinal_kontrol >= lblkontrol)
                    {
                        satin_al();
                        label6.ForeColor = Color.Green;
                        label6.Text = "Satın Alındı\nSatılmayı Bekleniyor";
                        kontrol = false;
                        if (label6.Text == "Satın Alındı\nSatılmayı Bekleniyor")
                        {
                            kontrol2 = true;
                        }
                    }
                }
                if (kontrol2 == true)
                {
                    if (label6.Text == "Satın Alındı\nSatılmayı Bekleniyor")
                    {
                        if (lblkontrol >= coinsat_kontrol)
                        {
                            bozdur_sat();
                            label6.ForeColor = Color.Red;
                            label6.Text = "Satıldı\nSatın Alma Bekleniyor";
                            kontrol2 = false;
                            kontrol = true;

                        }
                    }

                }
            }
            catch (Exception)
            {

                switch (buttonyonel == true)
                {
                    case true:
                        siteyonel();
                        Thread.Sleep(9999);
                        sifirdanhareket_analizi();
                        break;
                }


            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            siteyonel();
        }

       
    }



}

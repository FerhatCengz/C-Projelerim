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
namespace FutbolOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //720 kaleci
            //501 top
            // goal



            Random rndm = new Random();


            int kaleci = 0, top = 0;
            kaleci = rndm.Next(154, 721);
            int x = 0, y = 0, z = 0;
            x = 138;
            y = 507;
            z = 828;

            Point point = new Point();
            point.X = kaleci;
            point.Y = 37;
            pngbekci.Location = point;


            //Point pointballs = new Point();
            //pointballs.X = 138;
            //pointballs.Y = 238;
            //pngtop.Location = pointballs;

            //Point pointballs2 = new Point();
            //pointballs2.X = 507;
            //pointballs2.Y = 238;
            //pngtop.Location = pointballs2;

            //Point pointballs3= new Point();
            //pointballs3.X = 828;
            //pointballs3.Y = 238;
            //pngtop.Location = pointballs3;



            ////138; 239
            ////507; 232
            ////828; 224

            if (kaleci > x && kaleci > 276)
            {
                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                wmp.URL = "C:\\Users\\User\\OneDrive\\Masaüstü\\Futbol Oyunu\\gol.mp3";

                Point pointballs = new Point();
                pointballs.X = 138;
                pointballs.Y = 238;
                pngtop.Location = pointballs;
                MessageBox.Show("Goall");
                pointballs.X = 507;
                pointballs.Y = 634;
                pngtop.Location = pointballs;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;
            }
            else
            {
                Point pointballs = new Point();
                pointballs.X = kaleci;
                pointballs.Y = 238;
                pngtop.Location = pointballs;
                MessageBox.Show("Tekrar Deneyiniz");
                pointballs.X = 507;
                pointballs.Y = 634;
                pngtop.Location = pointballs;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;
            }




            //if (kaleci > y && kaleci < 693)
            //{
            //    Point pointballs = new Point();
            //    pointballs.X = kaleci;
            //    pointballs.Y = 238;
            //    pngtop.Location = pointballs;
            //    MessageBox.Show("Tekrar Deneyiniz");
            //}



        }


        int kaleci = 447;


        private void timer1_Tick(object sender, EventArgs e)
        {

            Point filebekci = new Point();
            filebekci.X = kaleci -= 100;
            filebekci.Y = 37;
            pngbekci.Location = filebekci;

            if (kaleci == 147)
            {
                timer1.Stop();
                timer2.Start();

            }




        }
        int kaleci2 = 147;
        private void timer2_Tick(object sender, EventArgs e)
        {

            Point filebekci2 = new Point();
            filebekci2.X = kaleci2 += 100;
            filebekci2.Y = 37;
            pngbekci.Location = filebekci2;
            if (kaleci2 == 447)
            {
                timer2.Stop();
                timer3.Start();
            }
        }


        int kaleci3 = 447;
        private void timer3_Tick(object sender, EventArgs e)
        {
            Point filebekci3 = new Point();
            filebekci3.X = kaleci3 += 100;
            filebekci3.Y = 37;
            pngbekci.Location = filebekci3;
            if (kaleci3 == 747)
            {
                timer3.Stop();
                filebekci3.X = 447;
                filebekci3.Y = 37;
                pngbekci.Location = filebekci3;
                pngtop.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Random rndm = new Random();


            int kaleci = 0, top = 0;
            kaleci = rndm.Next(154, 721);

            int x = 0, y = 0, z = 0;
            x = 138;
            y = 317;
            z = 828;

            Point ortaya = new Point();
            ortaya.X = kaleci;
            ortaya.Y = 37;
            pngbekci.Location = ortaya;

            if (kaleci > 274 && kaleci < 635)
            {
                Point pointballs2 = new Point();
                pointballs2.X = 507;
                pointballs2.Y = 238;
                pngtop.Location = pointballs2;
                MessageBox.Show("Tekrar Deneyiniz");
                pointballs2.X = 507;
                pointballs2.Y = 634;
                pngtop.Location = pointballs2;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;
            }
            else
            {
                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                wmp.URL = "C:\\Users\\User\\OneDrive\\Masaüstü\\Futbol Oyunu\\gol.mp3";

                Point pointballs2 = new Point();
                pointballs2.X = 507;
                pointballs2.Y = 238;
                pngtop.Location = pointballs2;
                MessageBox.Show("Goall");
                pointballs2.X = 507;
                pointballs2.Y = 634;
                pngtop.Location = pointballs2;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;
            }







        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();


            int kaleci = 0, top = 0;
            kaleci = rndm.Next(154, 721);
            int x = 0, y = 0, z = 0;
            x = 138;
            y = 317;
            z = 828;

            Point ortaya = new Point();
            ortaya.X = kaleci;
            ortaya.Y = 37;
            pngbekci.Location = ortaya;

            if (kaleci > 601 && kaleci < 900)
            {
                Point pointballs3 = new Point();
                pointballs3.X = 828;
                pointballs3.Y = 238;
                pngtop.Location = pointballs3;
                MessageBox.Show("Tekrar Deneyin");
                pointballs3.X = 507;
                pointballs3.Y = 634;
                pngtop.Location = pointballs3;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;

            }
            else
            {
                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                wmp.URL = "C:\\Users\\User\\OneDrive\\Masaüstü\\Futbol Oyunu\\gol.mp3";

                Point pointballs3 = new Point();
                pointballs3.X = 828;
                pointballs3.Y = 238;
                pngtop.Location = pointballs3;
                MessageBox.Show("Gaolll");
                pointballs3.X = 507;
                pointballs3.Y = 638;
                pngtop.Location = pointballs3;

                Point point2 = new Point();
                point2.X = 447;
                point2.Y = 37;
                pngbekci.Location = point2;

            }
        }
   
    }


}


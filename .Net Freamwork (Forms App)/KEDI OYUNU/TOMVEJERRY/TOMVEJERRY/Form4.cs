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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int sagailerle = 0;
        int solailerle = 0;
        int assain = 0;
        private void Form4_Load(object sender, EventArgs e)
        {

        }




        public void ilerle_sag()
        {
            Point point = new Point();
            point.X = sagailerle += 120;
            point.Y = 43;
            pictureBox1.Location = point;
            label1.Text = sagailerle.ToString();
            if (pictureBox1.Location.Y == 180)
            {
                Point point2 = new Point();
                point2.X = sagailerle += 120;
                point2.Y = 180;
                pictureBox1.Location = point2;
                label1.Text = sagailerle.ToString();

            }

        }
        public void ilerle_sol()
        {
            solailerle += 120;
            Point point = new Point();
            point.X = sagailerle -= 120;
            point.Y = 43;
            pictureBox1.Location = point;
        }
        public void ilerle_assa()
        {

            
            Point point = new Point();
            point.X = 240;
            point.Y = 180;
            pictureBox1.Location = point;

            
            



        }
        public void restart()
        {
            Point point = new Point(18, 43);
            pictureBox1.Location = point;
            solailerle = 0;
            sagailerle = 0;
            assain = 0;

        }

        public void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                ilerle_sag();
            }

            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Location.X > 0 && pictureBox1.Location.X > 18)
                {
                    ilerle_sol();

                }

            }

            if (pictureBox1.Location.X == 240)
            {
                if (e.KeyCode == Keys.Down)
                {
                    ilerle_assa();

                }
            }















            if (pictureBox1.Location.X == 480)
            {

                restart();
            }




        }
    }
}

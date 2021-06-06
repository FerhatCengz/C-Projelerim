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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int sagailerle = 0;
        int solailerle = 0;
        int yukariilerle = 0;

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Point point = new Point();
                point.X = sagailerle += 112;
                point.Y = 380;
                pictureBox1.Location = point;
                label1.Text = sagailerle.ToString();

                if (pictureBox1.Location.X == 672)
                {
                    sagailerle = 560;
                }
            }


            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Location.X > 12 && pictureBox1.Location.X > 10)
                {
                    solailerle += 112;
                    Point point2 = new Point();
                    point2.X = sagailerle -= 112;
                    point2.Y = 380;
                    pictureBox1.Location = point2;
                    label2.Text = solailerle.ToString();


                }

            }

            if (pictureBox1.Location.X == 448)
            {

                Point point3 = new Point(603, 54);
                pictureBox1.Location = point3;
                DialogResult ok = MessageBox.Show("Başarılı");
                if (ok == DialogResult.OK)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Close();
                }


            }




        }
    }
}

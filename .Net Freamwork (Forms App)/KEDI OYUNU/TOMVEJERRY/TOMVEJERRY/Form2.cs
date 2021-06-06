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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int ilerle = 0;
        int assa = 0;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                Point point = new Point();
                point.X = ilerle += 200;
                point.Y = 1;
                pictureBox1.Location = point;
                label1.Text = ilerle.ToString();
                if (pictureBox1.Location.X == 800)
                {
                    ilerle = 600;

                }

            }




            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (pictureBox1.Location.X == 800)
                {
                    ilerle -= 200;
                    Point assain = new Point();
                    assain.X = 800;
                    assain.Y = assa += 75;
                    pictureBox1.Location = assain;
                   
                    
                }
                if (pictureBox1.Location.Y == 375)
                {
                    DialogResult ok = MessageBox.Show("Başarılı");
                    if (ok == DialogResult.OK)
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Close();
                    }
                }

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

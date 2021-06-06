using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin2Bot
{
    public partial class FrmPozisyon : Form
    {
        public FrmPozisyon()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelx.Text = "X : "+MousePosition.X.ToString();
            labely.Text = "Y : "+MousePosition.Y.ToString();
        }
    }
}

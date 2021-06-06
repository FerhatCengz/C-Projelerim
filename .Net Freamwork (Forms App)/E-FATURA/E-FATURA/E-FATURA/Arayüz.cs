using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_FATURA
{
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Efaturagiris efatura = new Efaturagiris();
            efatura.Show();
            
        }
    }
}

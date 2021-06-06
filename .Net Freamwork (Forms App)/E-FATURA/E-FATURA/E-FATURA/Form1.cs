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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string il;
        public string telno;
        public string eposta;
        public string vergidairesi;
        public string vkn;
        public string firmadi;
        public string eposta2;
        public string telno2;
        public string vergidairesi2;
        public string vkn2;
        public string ETTN;
        public string ozellestirme;
        public string senaryo;
        public string faturatipi;
        public string faturano;
        public string faturatarihi;
        public string irsaliyeno;
        public string irsaliyetarihi;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_il.Text = il;
            lbl_telno.Text = "Tel: "+telno;
            lbl_eposta.Text = "E-Posta: "+eposta;
            lbl_vergidairesi.Text = "Vergi Dairesi: "+vergidairesi;
            lbl_vkn.Text = "VKN: "+vkn;
            lbl_firmaadi.Text = firmadi + " FIRMASI";
            lbl_eposta2.Text = "E-Posta: "+eposta2;
            lbl_telno2.Text = "Tel: "+telno2;
            lbl_vergidairesi2.Text = "Vergi Dairesi: "+vergidairesi2;
            lbl_vkn2.Text = "VKN: " + vkn2;
            lbl_ettn.Text = ETTN;
            lbl_ozellestirme.Text = ozellestirme;
            lbl_senaryo.Text = senaryo;
            lbl_faturatipi.Text = faturatipi;
            lbl_faturano.Text = faturano;
            lbl_faturatarihi.Text = faturatarihi;
            lbl_irsaliyeno.Text = irsaliyeno;
            lbl_irsaliyetarihi.Text = irsaliyetarihi;




        }

      
    }
}

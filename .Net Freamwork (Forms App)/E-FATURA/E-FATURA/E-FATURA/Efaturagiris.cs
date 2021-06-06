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
    public partial class Efaturagiris : Form
    {
        public Efaturagiris()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.il = txt_il.Text;
            frm.telno = text_telno.Text;
            frm.eposta = text_eposta.Text;
            frm.vergidairesi = text_vergidairesi.Text;
            frm.vkn = text_vkn.Text;
            frm.firmadi = txt_firmaadi.Text;
            frm.eposta2 = text_eposta2.Text;
            frm.telno2 = text_telno2.Text;
            frm.vergidairesi2 = text_vergidairesi2.Text;
            frm.ETTN = text_ettn.Text;
            frm.ozellestirme = text_ozellestirme.Text;
            frm.senaryo = text_senaryo.Text;
            frm.faturatipi = text_faturatipi.Text;
            frm.faturano = text_faturano.Text;
            frm.faturatarihi = date_fatura.Text;
            frm.irsaliyeno = text_irsaliyeno.Text;
            frm.irsaliyetarihi = date_irsaliye.Text;
            frm.Show();




        }

        
    }
}

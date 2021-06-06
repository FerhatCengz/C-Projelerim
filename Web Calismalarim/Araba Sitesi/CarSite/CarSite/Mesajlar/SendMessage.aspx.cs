using CarSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSite.Mesajlar
{
    public partial class SendMessage : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string kad = Session["KAD"].ToString();
                    string mesajid = Request.QueryString["GELENKAD"].ToString();
                    Alici_Text.Text = mesajid;

                }
                catch (Exception)
                {

                    Response.Redirect("/Index/Index.aspx");
                }
            }



        }

        protected void Btn_Gonder_Click(object sender, EventArgs e)
        {
            string kad = Session["KAD"].ToString();
            Tbl_Mesajlar mesajlar = new Tbl_Mesajlar();
            mesajlar.GONDEREN_KULLANICI = kad;
            mesajlar.ALICI_KULLANICI = Alici_Text.Text;
            mesajlar.BASLIK = BASLIK_Text.Text;
            mesajlar.ICERIK = Icerik_Text.InnerText;
            mesajlar.TARIH = DateTime.Now;
            mesajlar.DURUM = false;
            db.Tbl_Mesajlar.Add(mesajlar);
            db.SaveChanges();
            Response.Redirect("/Mesajlar/GidenKutusu.aspx");
        }
    }
}
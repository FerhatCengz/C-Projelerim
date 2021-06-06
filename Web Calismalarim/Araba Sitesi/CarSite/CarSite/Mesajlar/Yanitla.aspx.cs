using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Mesajlar
{
    public partial class Yanitla : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string kad = Session["KAD"].ToString();
                    int mesajid = Convert.ToInt32(Request.QueryString["MESAJID"].ToString());

                    var idyegoregetir = db.Tbl_Mesajlar.Find(mesajid);
                    mesajid = idyegoregetir.MESAJID;
                    BASLIK_Text.Text = idyegoregetir.BASLIK;
                    Gonderen_Text.Text = idyegoregetir.GONDEREN_KULLANICI;
                    db.SaveChanges();

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
            mesajlar.ALICI_KULLANICI = Gonderen_Text.Text;
            mesajlar.BASLIK = BASLIK_Text.Text;
            mesajlar.ICERIK = Icerik_Text.InnerText;
            mesajlar.TARIH = DateTime.Now;
            db.Tbl_Mesajlar.Add(mesajlar);
            mesajlar.DURUM = false;
            db.SaveChanges();
            Response.Redirect("/Mesajlar/GidenKutusu.aspx");
        }
    }
}
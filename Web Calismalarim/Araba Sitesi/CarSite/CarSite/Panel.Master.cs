using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite
{
    public partial class Panel : System.Web.UI.MasterPage
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label tuttum = new Label();
                string grs = Session["KAD"].ToString();
                lblTotalMessage.Text = db.Tbl_Mesajlar.Where(x => x.ALICI_KULLANICI == grs && x.DURUM == false).Count().ToString();
                if (grs != "")
                {
                    Grs_Yap.Text = grs;
                    Kyt_Ol.Visible = false;
                    Grs_Yap.NavigateUrl = "/Index/Index.aspx";
                    Cks_Yap.Visible = true;

                }
                else
                {
                    Grs_Yap.Text = "Giriş Yap";
                }
            }
            catch (Exception)
            {

                Response.Redirect("/Login/Login.aspx");
            }

        }


    }
}
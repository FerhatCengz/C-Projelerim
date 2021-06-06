using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Mesajlar
{
    public partial class GidenKutusu : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    string kad = Session["KAD"].ToString();
                    Total_Set_Message.Text = db.Tbl_Mesajlar.Where(y => y.GONDEREN_KULLANICI == kad).Count().ToString();
                    lbl_Okunan.Text = db.Tbl_Mesajlar.Where(x => x.DURUM == true && x.ALICI_KULLANICI == kad).Count().ToString();
                    var query = (from x in db.Tbl_Mesajlar
                                 where x.GONDEREN_KULLANICI == kad
                                 select new
                                 {
                                     x.MESAJID,
                                     x.TARIH,
                                     x.ALICI_KULLANICI,
                                     x.BASLIK,
                                     x.ICERIK
                                 }).ToList().OrderByDescending(x => x.TARIH);

                    Repeater1.DataSource = query;
                    Repeater1.DataBind();

                }
            }
            catch (Exception)
            {

                Response.Redirect("/Index/Index.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Mesajlar
{
    public partial class DeleteGiden2 : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idyitut = Convert.ToInt32(Request.QueryString["MESAJID"].ToString());
            var delete = db.Tbl_Mesajlar.Find(idyitut);
            db.Tbl_Mesajlar.Remove(delete);
            db.SaveChanges();
            Response.Redirect("/Mesajlar/Mesajlar.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Login
{
    public partial class Login : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            var query = (from x in db.Tbl_Kullancılar where x.KAD == Kad_Text.Text && x.PASS == Pass_Text.Text select x);
            if (query.Any())
            {
                Session.Add("KAD",Kad_Text.Text);
                Response.Redirect("/Piyasa/Piyasa.aspx");

            }
            else
            {
                Response.Write("Hatalı Bilgi Girişi");

            }
        }

    }
}
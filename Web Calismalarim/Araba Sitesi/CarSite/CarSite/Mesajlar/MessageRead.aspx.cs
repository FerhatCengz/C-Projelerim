using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Mesajlar
{
    public partial class MessageRead : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string kad = Session["KAD"].ToString();
            Total_Set_Message.Text = db.Tbl_Mesajlar.Where(y => y.GONDEREN_KULLANICI == kad).Count().ToString();
            lbl_Okunan.Text = db.Tbl_Mesajlar.Where(x => x.DURUM == true && x.ALICI_KULLANICI == kad).Count().ToString();
            var getir = (from x in db.Tbl_Mesajlar
                         where x.ALICI_KULLANICI == kad && x.DURUM == true
                         select new
                         {
                             x.MESAJID,
                             x.TARIH,
                             x.GONDEREN_KULLANICI,
                             x.BASLIK,
                             x.ICERIK
                         }).ToList().OrderByDescending(x => x.TARIH);
            Repeater1.DataSource = getir;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "DeleteBtn":
                    int id = Convert.ToInt32(e.CommandArgument.ToString());
                    var delete = db.Tbl_Mesajlar.Find(id);
                    db.Tbl_Mesajlar.Remove(delete);
                    db.SaveChanges();
                    Response.Redirect("/Mesajlar/MessageRead.aspx");
                    break;
            }
        }
    }
}
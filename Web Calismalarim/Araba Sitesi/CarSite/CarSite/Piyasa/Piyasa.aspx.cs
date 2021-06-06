using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Piyasa
{
    public partial class Piyasa : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {



            var getir = (from x in db.Tbl_Ilanlar
                         select new
                         {
                             x.KAD_ID,
                             x.RESIM,
                             MARKA = x.Tbl_Marka.MARKA_ADI,
                             MODEL = x.Tbl_Modeller.MODELADI,
                             x.ARAC_YILI,
                             x.FİYAT,
                         }).ToList();
            Repeater1.DataSource = getir;
            Repeater1.DataBind();


        }
    }
}
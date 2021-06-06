using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Piyasa
{
    public partial class Piyasa2 : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();

        int gelenmarka = 0;
        int gelenmodel = 0;
        decimal gelenpara = 0;
        decimal gelenpara2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                gelenmarka = Convert.ToInt32(Request.QueryString["MARKA"].ToString());
                gelenmodel = Convert.ToInt32(Request.QueryString["MODEL"].ToString());
                gelenpara = decimal.Parse(Request.QueryString["FİYAT"].ToString());
                gelenpara2 = decimal.Parse(Request.QueryString["FİYAT2"].ToString());


                if (gelenpara == 0 && gelenpara2 == 0)
                {
                    gelenpara = 0;
                    gelenpara2 = 3200000000;
                }

                if (gelenmarka == 14 && gelenmodel == 14)
                {
                    var sonuc2 = (from x in db.Tbl_Ilanlar
                                  where x.FİYAT >= gelenpara && x.FİYAT <= gelenpara2
                                  select new
                                  {
                                      x.KAD_ID,
                                      x.RESIM,
                                      MARKA = x.Tbl_Marka.MARKA_ADI,
                                      MODEL = x.Tbl_Modeller.MODELADI,
                                      x.ARAC_YILI,
                                      FİYAT = x.FİYAT + " TL",
                                  }).ToList();
                    Repeater1.DataSource = sonuc2;
                    Repeater1.DataBind();
                }
                else
                {
                    var sonuc = (from x in db.Tbl_Ilanlar
                                 where x.MARKA == gelenmarka && x.MODEL == gelenmodel && x.FİYAT >= gelenpara && x.FİYAT <= gelenpara2
                                 select new
                                 {
                                     x.KAD_ID,
                                     x.RESIM,
                                     MARKA = x.Tbl_Marka.MARKA_ADI,
                                     MODEL = x.Tbl_Modeller.MODELADI,
                                     x.ARAC_YILI,
                                     FİYAT = x.FİYAT + " TL",
                                 }).ToList();
                    Repeater1.DataSource = sonuc;
                    Repeater1.DataBind();
                }
                if (gelenmarka != 14 && gelenmodel == 14)
                {
                    var sonuc3 = (from x in db.Tbl_Ilanlar
                                  where x.MARKA == gelenmarka && x.FİYAT >= gelenpara && x.FİYAT <= gelenpara2
                                  select new
                                  {
                                      x.KAD_ID,
                                      x.RESIM,
                                      MARKA = x.Tbl_Marka.MARKA_ADI,
                                      MODEL = x.Tbl_Modeller.MODELADI,
                                      x.ARAC_YILI,
                                      FİYAT = x.FİYAT + " TL",
                                  }).ToList();
                    Repeater1.DataSource = sonuc3;
                    Repeater1.DataBind();
                }
            }
            catch (Exception)
            {
                string yakala = Request.QueryString["query"].ToString();
                var sonuc = (from x in db.Tbl_Ilanlar
                             where x.Tbl_Marka.MARKA_ADI.StartsWith(yakala) || x.Tbl_Modeller.MODELADI.StartsWith(yakala) || x.Tbl_Kullancılar.ADI.StartsWith(yakala) || x.Tbl_Kullancılar.KAD.StartsWith(yakala)
                             select new
                             {
                                 x.KAD_ID,
                                 x.RESIM,
                                 MARKA = x.Tbl_Marka.MARKA_ADI,
                                 MODEL = x.Tbl_Modeller.MODELADI,
                                 x.ARAC_YILI,
                                 FİYAT = x.FİYAT + " TL",
                             }).ToList();
                Repeater1.DataSource = sonuc;
                Repeater1.DataBind();

            }



        }

    }
}

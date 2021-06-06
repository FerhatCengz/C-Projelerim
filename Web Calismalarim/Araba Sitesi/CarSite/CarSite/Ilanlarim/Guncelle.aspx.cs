using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Ilanlarim
{
    public partial class Guncelle : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=EntityAraba;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    Marka_Drop.SelectedValue = 14.ToString();

                    int idtut = Convert.ToInt32(Request.QueryString["KAD_ID"].ToString());
                    var gg = db.Tbl_Ilanlar.Find(idtut);
                    Resim.Text = gg.RESIM;
                    Yil_TEXT.Text = gg.ARAC_YILI;
                    KM_TEXT.Text = gg.KM;
                    Yakit_Drop.Text = gg.YAKIT_TURU.ToString();
                    Vites_Drop.Text = gg.VITES_TIPI.ToString();
                    MotorHacmi_Text.Text = gg.MOTOR_HACMI;
                    MotorGucu_Text.Text = gg.MOTOR_GUCU;
                    Kimden_Drop.Text = gg.KIMDEN.ToString();
                    Aciklama_Text.InnerText = gg.ACIKLAMA;
                    Fiyat_Text.Text = gg.FİYAT.ToString();
                    db.SaveChanges();

                    string kad = Session["KAD"].ToString();
                    Satan_Text.Text = kad;


                    var query = (from x in db.Tbl_Marka select new { x.MARKA_ADI, x.MARKAID }).ToList().Distinct();
                    Marka_Drop.DataSource = query;
                    Marka_Drop.DataTextField = "MARKA_ADI";
                    Marka_Drop.DataValueField = "MARKAID";
                    Marka_Drop.DataBind();
                    var query3 = (from x in db.Tbl_Ilanlar select new { x.YAKIT_TURU }).ToList().Distinct();
                    Yakit_Drop.DataSource = query3;
                    Yakit_Drop.DataTextField = "YAKIT_TURU";
                    Yakit_Drop.DataBind();


                    var query4 = (from x in db.Tbl_Ilanlar select new { x.VITES_TIPI }).ToList().Distinct();
                    Vites_Drop.DataSource = query4;
                    Vites_Drop.DataTextField = "VITES_TIPI";
                    Vites_Drop.DataBind();

                    var query5 = (from x in db.Tbl_Ilanlar select new { x.KIMDEN }).ToList().Distinct();
                    Kimden_Drop.DataSource = query5;
                    Kimden_Drop.DataTextField = "KIMDEN";
                    Kimden_Drop.DataBind();
                }
                catch (Exception)
                {

                    Response.Redirect("/Index/Index.aspx");
                }
            }
        }

        protected void Marka_Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query2 = (from x in db.Tbl_Modeller where x.MRKAID.ToString() == Marka_Drop.Text.ToString() select new { x.MODELADI, x.MODELID }).ToList().Distinct();
            Model_Drop.DataSource = query2;
            Model_Drop.DataTextField = "MODELADI";
            Model_Drop.DataValueField = "MODELID";
            Model_Drop.DataBind();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Aciklama_Text.InnerText = "KİRALIK";
                Aciklama_Text.Visible = false;

            }
        }

        protected void Btn_Ekle_Click(object sender, EventArgs e)
        {

            if (Marka_Drop.SelectedValue != 14.ToString())
            {
                int idtut = Convert.ToInt32(Request.QueryString["KAD_ID"].ToString());
                var islem = db.Tbl_Ilanlar.Find(idtut);
                islem.RESIM = Resim.Text;
                islem.MARKA = int.Parse(Marka_Drop.SelectedValue);
                islem.MODEL = int.Parse(Model_Drop.SelectedValue);
                islem.ARAC_YILI = Yil_TEXT.Text;
                islem.KM = KM_TEXT.Text;
                islem.YAKIT_TURU = Yakit_Drop.SelectedValue;
                islem.MOTOR_HACMI = MotorHacmi_Text.Text;
                islem.MOTOR_GUCU = MotorGucu_Text.Text;
                islem.KIMDEN = Kimden_Drop.SelectedValue;
                islem.ACIKLAMA = Aciklama_Text.InnerText;
                islem.FİYAT = decimal.Parse(Fiyat_Text.Text);
                db.SaveChanges();
                Response.Redirect("Incele_Guncelle.aspx?KAD_ID=" + idtut);
            }
            if (Marka_Drop.SelectedValue == 14.ToString())
            {
                string str3 = "Formu Tekrar Gözden Geçirin";
                Response.Write("<script language=javascript>alert('" + str3 + "');</script>");
            }

        }
    }
}
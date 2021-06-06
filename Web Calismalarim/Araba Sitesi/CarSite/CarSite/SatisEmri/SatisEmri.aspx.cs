using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.SatisEmri
{

    public partial class SatisEmri : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=EntityAraba;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
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

            }
            catch (Exception)
            {

                Response.Redirect("/Login/Login.aspx");
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

        protected void Btn_Ekle_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();

            string kad = Session["KAD"].ToString();

            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID , KAD FROM Tbl_Kullancılar WHERE KAD = @p1", bgl);
            cmd.Parameters.AddWithValue("@p1", kad);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Satan_Text.Text = dr[0].ToString();
                lbl.Text = Satan_Text.Text;
            }
            bgl.Close();
            Label saat = new Label();
            saat.Text = DateTime.Now.ToString();
            Tbl_Ilanlar ilan = new Tbl_Ilanlar();
            ilan.SATAN_KULLANICI = int.Parse(lbl.Text);
            ilan.RESIM = Resim.Text;
            ilan.MARKA = int.Parse(Marka_Drop.SelectedValue);
            ilan.MODEL = int.Parse(Model_Drop.SelectedValue);
            ilan.ARAC_YILI = Yil_TEXT.Text;
            ilan.KM = KM_TEXT.Text;
            ilan.YAKIT_TURU = Yakit_Drop.Text;
            ilan.VITES_TIPI = Vites_Drop.Text;
            ilan.MOTOR_HACMI = MotorHacmi_Text.Text;
            ilan.MOTOR_GUCU = MotorGucu_Text.Text;
            ilan.KIMDEN = Kimden_Drop.Text;
            ilan.ACIKLAMA = Aciklama_Text.InnerText;
            ilan.FİYAT = decimal.Parse(Fiyat_Text.Text);
            ilan.ILAN_TARIHI = DateTime.Parse(saat.Text);
            db.Tbl_Ilanlar.Add(ilan);
            db.SaveChanges();
            Response.Redirect("/Piyasa/Piyasa.aspx");


        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Aciklama_Text.InnerText = "KİRALIK";
                Aciklama_Text.Visible = false;

            }
        }
    }
}
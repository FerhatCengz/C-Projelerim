using CarSite.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSite.KayıtOl
{
    public partial class KayıtOl : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=EntityAraba;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Kad_Text.Text != "" && Pass_Text.Text != "" && email_text.Text != "" && Adınız_TEXT.Text != "" && Soyadınız_Text.Text != "")
            {

                bgl.Open();
                SqlCommand cmd = new SqlCommand("SELECT KAD FROM Tbl_Kullancılar WHERE KAD = @p1 ", bgl);
                cmd.Parameters.AddWithValue("@p1", Kad_Text.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {

                    if (dr[0].ToString() == Kad_Text.Text)
                    {
                        string str3 = "Kayıt Mevcut";
                        Response.Write("<script language=javascript>alert('" + str3 + "');</script>");

                    }


                }
                else
                {
                    Tbl_Kullancılar kullancılar = new Tbl_Kullancılar();
                    kullancılar.ADI = Adınız_TEXT.Text;
                    kullancılar.SOYADI = Soyadınız_Text.Text;
                    kullancılar.KAD = Kad_Text.Text;
                    kullancılar.PASS = Pass_Text.Text;
                    kullancılar.MAIL = email_text.Text;
                    db.Tbl_Kullancılar.Add(kullancılar);
                    db.SaveChanges();
                    Response.Redirect("/Login/Login.aspx");

                }


                bgl.Close();



            }
            else
            {
                string str = "Kayıt Formunu Tekrar Gözden Geçiriniz";
                Response.Write("<script language=javascript>alert('" + str + "');</script>");
            }

        }

    }
}

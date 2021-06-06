﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
namespace CarSite.Ilanlarim
{
    public partial class Incele_Guncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=EntityAraba;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                EntityArabaEntities1 db = new EntityArabaEntities1();
                int kadid = Convert.ToInt32(Request.QueryString["KAD_ID"].ToString());

                bgl.Open();
                SqlCommand cmd = new SqlCommand("SELECT (ADI+' '+SOYADI) AS ADI , MARKA_ADI ,MODELADI FROM TBL_ILANLAR A JOIN Tbl_Kullancılar B ON B.ID = A.SATAN_KULLANICI JOIN Tbl_Marka C ON C.MARKAID = A.MARKA JOIN Tbl_Modeller D ON D.MODELID = A.MODEL WHERE A.KAD_ID = @p1", bgl);
                cmd.Parameters.AddWithValue("@p1", kadid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Satan_Kullanici.Text = dr[0].ToString();
                    Marka_text.Text = dr[1].ToString();
                    Model_text.Text = dr[2].ToString();
                }
                bgl.Close();

                var id = db.Tbl_Ilanlar.Find(kadid);
                Resimciii.ImageUrl = id.RESIM;
                ilan_tarihi.Text = id.ILAN_TARIHI.ToString();
                string metin = ilan_tarihi.Text.Remove(11);
                ilan_tarihi.Text = metin;
                Arac_yili_Text.Text = id.ARAC_YILI.ToString();
                km_Text.Text = id.KM;
                Yakit_Turu_Text.Text = id.YAKIT_TURU;
                vites_tipi_Text.Text = id.VITES_TIPI;
                Motor_hacmi_Text.Text = id.MOTOR_HACMI;
                Motor_gucu_Text.Text = id.MOTOR_GUCU;
                Kimden_Text.Text = id.KIMDEN;
                Aciklama_Text.Text = id.ACIKLAMA;
                Fiyat_Text.Text = id.FİYAT + " TL";
                db.SaveChanges();
            }
            catch (Exception)
            {

                Response.Redirect("/Index/Index.aspx");
            }

        }

        protected void Guncelle_Click(object sender, EventArgs e)
        {
            int idtut = Convert.ToInt32(Request.QueryString["KAD_ID"].ToString());
            Response.Redirect("Guncelle.aspx?KAD_ID=" + idtut);
        }
    }
}
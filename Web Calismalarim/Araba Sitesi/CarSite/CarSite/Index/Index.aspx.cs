using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSite.Entity;
using CarSite.Piyasa;
namespace CarSite.Index
{
    public partial class Index : System.Web.UI.Page
    {
        EntityArabaEntities1 db = new EntityArabaEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
                OneEpsiode.Text = "0";
                TwoEpsiode.Text = "0";
                //var query = (from x in db.Tbl_Ilanlar where x.Tbl_Marka.MARKA_ADI.StartsWith(Drop_Marka.Text) select x);

                var query = (from x in db.Tbl_Marka select new { x.MARKAID, x.MARKA_ADI }).ToList().OrderBy(x => x.MARKA_ADI);
                Drop_Marka.DataSource = query;
                Drop_Marka.DataTextField = "MARKA_ADI";
                Drop_Marka.DataValueField = "MARKAID";
                Drop_Marka.DataBind();
                Drop_Marka.SelectedIndex = 14;
                Drop_Marka.SelectedValue = 14.ToString();

                if (Drop_Marka.SelectedValue == 14.ToString())
                {
                    var query2 = (from x in db.Tbl_Modeller where x.MODELID == 14 select new { x.MODELID, x.MODELADI }).ToList();
                    Drop_Model.DataSource = query2;
                    Drop_Model.DataTextField = "MODELADI";
                    Drop_Model.DataValueField = "MODELID";
                    Drop_Model.DataBind();

                }

            }

        }

        protected void Deneme_Click(object sender, EventArgs e)
        {
            //Response.Redirect("/Piyasa/Piyasa2.aspx?FİYAT=" + OneEpsiode.Text + "&FİYAT2=" + TwoEpsiode.Text);

            Response.Redirect("/Piyasa/Piyasa2.aspx?MARKA=" + Drop_Marka.Text + "&MODEL=" + Drop_Model.Text + "&FİYAT=" + OneEpsiode.Text + "&FİYAT2=" + TwoEpsiode.Text);

        }

        protected void Drop_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query2 = (from x in db.Tbl_Modeller where x.MRKAID.ToString() == Drop_Marka.SelectedValue.ToString() || x.MODELID == 14 select new { x.MODELID, x.MODELADI }).ToList();
            Drop_Model.DataSource = query2;
            Drop_Model.DataTextField = "MODELADI";
            Drop_Model.DataValueField = "MODELID";
            Drop_Model.DataBind();

        }

        protected void Tikla_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Piyasa/Piyasa2.aspx?query=" + Text_Aratilan.Text);
        }
    }
}
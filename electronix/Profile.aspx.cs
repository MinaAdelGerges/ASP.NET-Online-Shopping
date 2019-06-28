using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace electronix
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                DataTable dt = UsersLayer.GetUser(int.Parse(Session["id"].ToString()));
                lbl_name.Text = dt.Rows[0]["Name"].ToString();
                lbl_age.Text = dt.Rows[0]["Age"].ToString();
                lbl_email.Text = dt.Rows[0]["Email"].ToString();
                lbl_gender.Text = dt.Rows[0]["Gender"].ToString();
                img_profile.ImageUrl = dt.Rows[0]["Image"].ToString();
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
           
            HttpCookie co = new HttpCookie("user");
            co.Expires = DateTime.Now.AddDays(-15);
            Response.Cookies.Add(co);

            Response.Redirect("~/login.aspx");
        }
    }
}
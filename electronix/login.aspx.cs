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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user"] != null)
            {
                Session["id"] = Request.Cookies["user"].Values["id"];
                Response.Redirect("~/Profile.aspx");
            }
        }


        protected void btn_login_Click1(object sender, EventArgs e)
        {
            DataTable dt = UsersLayer.GetUserId(txt_name.Text, txt_password.Text);
            if (dt.Rows.Count > 0 && txt_name.Text=="admin"&&txt_password.Text=="admin")
            {
                Session["id"] = dt.Rows[0]["Id"];
                Session["admin"] = dt.Rows[0]["Id"];
                if (chb_remeberme.Checked)
                {
                    HttpCookie co = new HttpCookie("user");
                    co.Values.Add("id", dt.Rows[0]["Id"].ToString());
                    co.Values.Add("admin", dt.Rows[0]["Id"].ToString());

                    co.Expires = DateTime.Now.AddDays(15);

                    Response.Cookies.Add(co);
                    
                }
                Response.Redirect("~/Profile.aspx");
                
                
            }
            else if (dt.Rows.Count > 0 && txt_name.Text != "admin" && txt_password.Text != "admin")
            {
                Session["id"] = dt.Rows[0]["Id"];
                
                if (chb_remeberme.Checked)
                {
                    HttpCookie co = new HttpCookie("user");
                    co.Values.Add("id", dt.Rows[0]["Id"].ToString());

                    co.Expires = DateTime.Now.AddDays(15);

                    Response.Cookies.Add(co);

                }
                Response.Redirect("~/Profile.aspx");


            }
            else
            {
                lbl_status.Text = "invalid username or password";
            }
        }
    }
}
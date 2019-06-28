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
    public partial class changePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Request.Cookies["user"] == null && Session["id"]==null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    string newPass = txt_new.Text;
                    UsersLayer.changePassword(int.Parse(Request.Cookies["user"].Values["id"].ToString()), newPass);
                    lbl_save.Text = "New Password Saved Correctly!";
                }
            }
            catch
            {
                if (IsValid)
                {
                    string newPass = txt_new.Text;
                    UsersLayer.changePassword(int.Parse(Session["id"].ToString()), newPass);
                    lbl_save.Text = "New Password Saved Correctly!";
                }
            }
        }
    }
}
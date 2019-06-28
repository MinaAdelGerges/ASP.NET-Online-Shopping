using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace electronix
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string path = "~/attach/" + fu_photo.FileName;
                fu_photo.SaveAs(Server.MapPath(path));
                UsersLayer.InsertUser(txt_name.Text, int.Parse(txt_age.Text), txt_pass.Text, txt_email.Text, rbl_gender.Text, path);
                lbl_status.Text = "Product Added Successfuly!";
                Response.Redirect("~/login.aspx");
            }
        }
    }
}
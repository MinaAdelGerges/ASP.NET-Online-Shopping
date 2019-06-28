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
    public partial class editProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = UsersLayer.GetUser(int.Parse(Request.Cookies["user"].Values["id"]));
                txt_name.Text = dt.Rows[0]["Name"].ToString();
                txt_age.Text = dt.Rows[0]["Age"].ToString();
                txt_gender.Text = dt.Rows[0]["Gender"].ToString();
                txt_email.Text = dt.Rows[0]["Email"].ToString();
            }
            catch{
                DataTable dt = UsersLayer.GetUser(int.Parse(Session["id"].ToString()));
                txt_name.Text = dt.Rows[0]["Name"].ToString();
                txt_age.Text = dt.Rows[0]["Age"].ToString();
                txt_gender.Text = dt.Rows[0]["Gender"].ToString();
                txt_email.Text = dt.Rows[0]["Email"].ToString();
            }
            

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "~/attach/" + fu_img.FileName;
                fu_img.SaveAs(Server.MapPath(path));
                SqlCommand cmd = new SqlCommand("update Users set Name=@name, Age=@age, Gender=@gender, Email=@email, Image=@image where Id=@id");

                cmd.Parameters.AddWithValue("id", int.Parse(Request.Cookies["user"].Values["id"]));
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("age", int.Parse(txt_age.Text));
                cmd.Parameters.AddWithValue("gender", txt_gender.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("image", path);
                DBLayers.DML(cmd);
                //int x = DBLayers.DML(cmd);
                //Response.Write(x);
                Response.Redirect("~/Profile.aspx");
            }
            catch
            {
                string path = "~/attach/" + fu_img.FileName;
                fu_img.SaveAs(Server.MapPath(path));
                SqlCommand cmd = new SqlCommand("update Users set Name=@name, Age=@age, Gender=@gender, Email=@email, Image=@image where Id=@Sid");
                cmd.Parameters.AddWithValue("Sid", int.Parse(Session["id"].ToString()));
                //cmd.Parameters.AddWithValue("id", int.Parse(Request.Cookies["user"].Values["id"]));
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("age", int.Parse(txt_age.Text));
                cmd.Parameters.AddWithValue("gender", txt_gender.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("image", path);
                DBLayers.DML(cmd);
                //int x=DBLayers.DML(cmd);
                //Response.Write(x);
                Response.Redirect("~/Profile.aspx");
            }
          
        }
    }
}
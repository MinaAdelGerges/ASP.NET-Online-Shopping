using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace electronix
{
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
            
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {

            
                string path = "~/attach/" + fup_image.FileName;
                fup_image.SaveAs(Server.MapPath(path));
                int Type = int.Parse(ddl_type.SelectedValue);
                int price = int.Parse(txt_price.Text);
                ProductLayer.InsertProduct(Type, txt_productName.Text, price, txt_desc.Text, path);
                lbl_status.Text = "Product Added Successfuly!";
            Response.Redirect("~/homepage.aspx");
       
        }
    }
}
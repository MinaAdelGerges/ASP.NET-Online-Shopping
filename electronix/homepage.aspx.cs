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
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select * from Product");

            //DataTable dt = DBLayers.select(cmd);
            DataTable dt = ProductLayer.GetAllProducts();
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();
                imageButton.ImageUrl = dt.Rows[i]["Image"].ToString();
                imageButton.CssClass = "productImage";
                //imageButton.PostBackUrl = "~/cart.aspx?id="+dt.Rows[i]["Id"];

                Button btn = new Button();
                btn.CssClass = "cardButton";
                btn.Text = "Add To Cart";
                btn.PostBackUrl= "~/cart.aspx?id=" + dt.Rows[i]["Id"];

                lblName.Text = dt.Rows[i]["Name"].ToString();
                lblName.CssClass = "productName";

                lblPrice.Text = dt.Rows[i]["Price"].ToString()+" $";
                lblPrice.CssClass = "productPrice";

                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal {Text="<br/>"});
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(btn);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                pnl_products.Controls.Add(productPanel);
            }
        }
    }
}
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
    public partial class purchasedHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            

                if (IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        int id = Convert.ToInt32(Request.QueryString["id"]);
                        ProductLayer.DeleteProduct(id);
                    }
                }
                if (Session["id"] != null)
                {
                    SqlCommand cmd = new SqlCommand("select * from Cart c, Product p where c.ProductId = p.Id and c.UserId=@id");
                    cmd.Parameters.AddWithValue("id", int.Parse(Request.Cookies["user"].Values["id"]));
                    DataTable dt = DBLayers.select(cmd);
                    //DataTable dt = ProductLayer.GetAllProducts();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Panel productPanel = new Panel();
                        ImageButton imageButton = new ImageButton();
                        Label lblName = new Label();
                        Label lblPrice = new Label();
                        Label lblDate = new Label();
                        Label lblQuantity = new Label();
                        imageButton.ImageUrl = dt.Rows[i]["Image"].ToString();
                        imageButton.CssClass = "productImage";
                        //imageButton.PostBackUrl = "~/cart.aspx?id="+dt.Rows[i]["Id"];

                        Button btn = new Button();
                        btn.CssClass = "cardButton";
                        btn.Text = "Delete Order";
                        btn.PostBackUrl = "~/purchasedHistory.aspx?id=" + dt.Rows[i]["Id"];

                        lblName.Text = "Name: " + dt.Rows[i]["Name"].ToString();
                        lblName.CssClass = "productName";

                        lblDate.Text = "Purchased " + dt.Rows[i]["DatePurchased"].ToString();
                        lblDate.CssClass = "productPrice";

                        lblPrice.Text = "Price: " + dt.Rows[i]["Price"].ToString() + " $";
                        lblPrice.CssClass = "productPrice";

                        lblQuantity.Text = "Quantity: " + dt.Rows[i]["Amount"].ToString();
                        lblQuantity.CssClass = "productPrice";

                        productPanel.Controls.Add(imageButton);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });
                        productPanel.Controls.Add(lblName);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });
                        productPanel.Controls.Add(lblDate);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });
                        productPanel.Controls.Add(lblQuantity);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });
                        productPanel.Controls.Add(lblPrice);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });
                        productPanel.Controls.Add(btn);
                        productPanel.Controls.Add(new Literal { Text = "<br/>" });

                        pnl_products.Controls.Add(productPanel);
                    }
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }

            }

    }
    }

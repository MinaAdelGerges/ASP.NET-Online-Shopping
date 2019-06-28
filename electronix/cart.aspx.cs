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
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


            //SqlCommand cmd = new SqlCommand("select * from Product where Id="+ Convert.ToInt32(Request.QueryString["id"]));

            //DataTable dt = DBLayers.select(cmd);
            if (Session["id"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                DataTable dt = ProductLayer.GetProduct(id);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbl_price.Text = "Price Per Unit: <br/>$ " + dt.Rows[i]["Price"].ToString();
                    lbl_title.Text = dt.Rows[i]["Name"].ToString();
                    lbl_desc.Text = dt.Rows[i]["Description"].ToString();
                    lbl_item.Text = id.ToString();
                    img_product.ImageUrl = dt.Rows[i]["Image"].ToString();

                    int[] amount = Enumerable.Range(1, 20).ToArray();
                    ddl_amount.DataSource = amount;
                    ddl_amount.AppendDataBoundItems = true;
                    ddl_amount.DataBind();

                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }


        }

        protected void btn_addCart_Click(object sender, EventArgs e)
        {

            
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int amount = Convert.ToInt32(ddl_amount.SelectedValue);
            DateTime now = DateTime.Now;
            CartLayer.InsertCart(int.Parse(Session["id"].ToString()), id, amount, now);
            lbl_result.Text = "Successfully added";
        }
    }
}
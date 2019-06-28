using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace electronix
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            CategoryLayer.InsertCategory(txt_categoryName.Text);
            lbl_status.Text = txt_categoryName.Text + "Added Successfuly!";
        }
    }
}
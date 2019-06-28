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
    public partial class electronix : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                 if ((Session["id"]!=null))
                {
                    link_register.Visible = false;
                    link_login.Visible = false;
                    link_manage.Visible = false;
                }
                else if ((Session["admin"] != null))
                {
                    link_register.Visible = false;
                    link_login.Visible = false;
                  
                }
                else if (Request.Cookies["user"]!= null&& Request.Cookies["user"].Values["admin"] != null)
                {
                    link_login.Visible = false;
                    link_register.Visible = false;
                }
            }
            catch
            {
                if (Request.Cookies["user"].Values["id"] != null&&Request.Cookies["user"].Values["admin"]==null)
                {
                    link_login.Visible = false;
                    link_register.Visible = false;
                }
                else if(Request.Cookies["user"].Values["id"] != null&& Request.Cookies["user"].Values["admin"] != null)
                {
                    link_manage.Visible = false;
                }
                
                        else
                {
                    link_manage.Visible = false;
                }
            }
           




        }
    }
}
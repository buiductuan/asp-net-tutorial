using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore.AdminCP
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Auth"] == null) Response.Redirect("/AdminCP/Auth/Login.aspx");
        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            if (Session["Auth"] != null)
            {
                Session["Auth"] = null;
                Response.Redirect("/AdminCP/Auth/Login.aspx");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace BookStore.AdminCP.Categories
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(Request.QueryString["id"].ToString());
                new CateBLL().Delete(id);
                Response.Redirect("/AdminCP/Categories/List.aspx");
            }
            catch { }
        }
    }
}
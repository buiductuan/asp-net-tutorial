using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace BookStore.AdminCP.Books
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(Request.QueryString["id"].ToString());
                new BookBLL().Delete(id);
                Response.Redirect("/AdminCP/Books/List.aspx");
            }
            catch { }
        }
    }
}
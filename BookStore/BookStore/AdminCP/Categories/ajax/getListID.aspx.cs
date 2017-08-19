using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
namespace BookStore.AdminCP.Categories.ajax
{
    public partial class getListID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Category item in new CateBLL().getToAll())
            {
                Response.Write("#" + item.ID);
            }
        }
    }
}
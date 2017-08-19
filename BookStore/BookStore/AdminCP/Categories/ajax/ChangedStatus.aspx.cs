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
    public partial class ChangedStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(Request.QueryString["id"].ToString());
               bool result =  new CateBLL().ChangedStatus(id);
                if(result == true)
                    Response.Write("1");
                Response.Write("0");
            }
            catch { }
        }
    }
}
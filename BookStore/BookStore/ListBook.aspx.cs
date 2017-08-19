using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace BookStore
{
    public partial class ListBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                long id = long.Parse(RouteData.Values["cid"].ToString());
                _rptListBook.DataSource = new BookBLL().getByCateID(id);
                _rptListBook.DataBind();
            }
        }
    }
}
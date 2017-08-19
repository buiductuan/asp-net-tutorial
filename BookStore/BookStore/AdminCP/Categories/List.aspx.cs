using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace BookStore.AdminCP.Categories
{
    public partial class List : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            _rptListCategory.DataSource = cateBLL.getToAll();
            _rptListCategory.DataBind();
        }
    }
}
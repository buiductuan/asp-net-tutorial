using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
namespace BookStore
{
    public partial class Default : System.Web.UI.Page
    {
        private BookBLL bookBLL = new BookBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _rptListBook.DataSource = bookBLL.getToAllAvailable();
                _rptListBook.DataBind();
            }
        }
    }
}
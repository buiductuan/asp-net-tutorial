using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
namespace BookStore.AdminCP.Books
{
    public partial class List : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        private BookBLL bookBLL = new BookBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _rptListBook.DataSource = bookBLL.getToAll();
                _rptListBook.DataBind();
            }
        }

        protected string GetNameAParentBook(long id)
        {
            return cateBLL.getByID(id).Name;
        }
    }
}
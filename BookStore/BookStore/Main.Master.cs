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
    public partial class Main : System.Web.UI.MasterPage
    {
        private CateBLL cateBLL = new CateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _rptListCate.DataSource = cateBLL.getToAllAvailable();
                _rptListCate.DataBind();

                //hiển thị danh sách book đã xem
                if (Session["BookViewed"] != null)
                {
                    List<Book> lst = (List<Book>)Session["BookViewed"];
                    //_rptBookViewed.DataSource = lst;
                    //_rptBookViewed.DataBind();
                }
            }
        }
    }
}
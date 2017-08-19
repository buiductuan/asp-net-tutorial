using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using BLL.Tools;
namespace BookStore
{
    public partial class BookDetail : System.Web.UI.Page
    {
        private BookBLL bookBLL = new BookBLL();
        private CateBLL cateBLL = new CateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                long  id = long.Parse(RouteData.Values["bid"].ToString());
                var _book = bookBLL.getByID(id);
                string nameCate = cateBLL.getByID(long.Parse(_book.CateID.ToString())).Name;
                name_cate_book.InnerText = nameCate;
                name_cate_book.HRef = "/danh-muc-sach/" + Tools.convertToUnSign(nameCate) + "-" + _book.CateID;
                this_book.InnerText = _book.Name;
                this_book.Title = _book.Name;
                img_book.Src = _book.ImagePath;

                //Thêm vào danh sách đã xem
                if (Session["BookViewed"] == null)
                {
                    List<Book> lst = new List<Book>();
                    lst.Add(_book);
                    Session["BookViewed"] = lst;
                }
                else
                {
                    List<Book> lst = (List<Book>)Session["BookViewed"];
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].ID != _book.ID)
                        {
                            lst.Add(_book);
                        }
                    }
                }

            }
        }
        protected Book ThisBook()
        {
            long id = long.Parse(RouteData.Values["bid"].ToString());
           return bookBLL.getByID(id);
        }
    }
}
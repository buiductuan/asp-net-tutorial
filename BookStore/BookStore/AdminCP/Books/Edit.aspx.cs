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
    public partial class Edit : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        private BookBLL bookBLL = new BookBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    long id = long.Parse(Request.QueryString["id"].ToString());
                    var _book = bookBLL.getByID(id);
                    ddlCate.DataSource = cateBLL.getToAllAvailable();
                    ddlCate.DataTextField = "Name";
                    ddlCate.DataValueField = "ID";
                    ddlCate.DataBind();
                    ddlCate.SelectedValue = _book.CateID.ToString();
                    txtName.Text = _book.Name;
                    txtDesc.Text = _book.Description;
                    txtDetail.Text = _book.Detail;
                    txtMetaDesc.Text = _book.Meta_Description;
                    txtKeyword.Text = _book.Meta_Keyword;
                    numPrice.Text = _book.Price.ToString();
                    if (_book.Status == true)
                        rblStatus.SelectedIndex = 1;
                    rblStatus.SelectedIndex = 0;
                    img_preview.Src = _book.ImagePath;
                }
                catch { }
            }
        }

        protected void btnUpdateBook_Click(object sender, EventArgs e)
        {
            long id = long.Parse(Request.QueryString["id"].ToString());
            var _book = bookBLL.getByID(id);
            string path = _book.ImagePath;
            if (txtName.Text != "" && numPrice.Text != "")
            {
                if (img_upload.HasFile)
                {
                    path = "/assets/upload/images/book/" + img_upload.FileName;
                    bookBLL.Update(new Book()
                    {
                        ID = id,
                        Name = txtName.Text,
                        Description = txtDesc.Text,
                        CateID = long.Parse(ddlCate.SelectedValue.ToString()),
                        Detail = txtDetail.Text,
                        ImagePath = path,
                        Meta_Description = txtMetaDesc.Text,
                        Meta_Keyword = txtKeyword.Text,
                        Price = float.Parse(numPrice.Text),
                        Status = rblStatus.SelectedValue == "1" ? true : false
                    });
                    img_upload.SaveAs(Server.MapPath(path));
                }
                else
                {
                    bookBLL.Update(new Book()
                    {
                        ID = id,
                        Name = txtName.Text,
                        CateID= long.Parse(ddlCate.SelectedValue.ToString()),
                        Description = txtDesc.Text,
                        Detail = txtDetail.Text,
                        ImagePath = path,
                        Meta_Description = txtMetaDesc.Text,
                        Meta_Keyword = txtKeyword.Text,
                        Price = float.Parse(numPrice.Text),
                        Status = rblStatus.SelectedValue == "1" ? true : false
                    });
                }
            }
        }
    }
}
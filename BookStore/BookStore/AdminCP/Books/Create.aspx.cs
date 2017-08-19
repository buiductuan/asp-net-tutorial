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
    public partial class Create : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        private BookBLL bookBLL = new BookBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCate.DataSource = cateBLL.getToAllAvailable();
                ddlCate.DataTextField = "Name";
                ddlCate.DataValueField = "ID";
                ddlCate.DataBind();
            }
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            string path = "/assets/upload/images/book/";
            if (txtName.Text != "" && numPrice.Text != "")
            {
                if (img_upload.HasFile)
                {
                    path += img_upload.FileName;
                    bookBLL.Insert(new Book()
                    {
                        Name = txtName.Text,
                        Description = txtDesc.Text,
                        CateID = long.Parse(ddlCate.SelectedValue.ToString()),
                        Detail = txtDetail.Text,
                        ImagePath = path,
                        Meta_Description = txtMetaDesc.Text,
                        Meta_Keyword = txtKeyword.Text,
                        Price = float.Parse(numPrice.Text),
                        Status = rblStatus.SelectedValue == "1" ? true:false
                    });
                    img_upload.SaveAs(Server.MapPath(path));
                    Response.Redirect("/AdminCP/Books/List.aspx");
                }
                else
                {
                    bookBLL.Insert(new Book()
                    {
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
                    Response.Redirect("/AdminCP/Books/List.aspx");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.IO;
namespace BookStore.AdminCP.Categories
{
    public partial class Create : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCate_Click(object sender, EventArgs e)
        {
            string path = "/assets/upload/images/category/";
            if (txtName.Text != "")
            {
                if (img_upload.HasFile)
                {
                    path += img_upload.FileName;
                    cateBLL.Insert(
                       new Category()
                       {
                           Name = txtName.Text,
                           Description = txtDesc.Text,
                           ImagePath = path,
                           Meta_Description = txtMetaDesc.Text,
                           Meta_Keyword = txtKeyword.Text,
                           Status = rblStatus.SelectedValue.ToString() == "1" ? true : false
                       });
                    img_upload.SaveAs(Server.MapPath(path));
                    Response.Redirect("/AdminCP/Categories/List.aspx");
                }
                else
                {
                    path += "none.png";
                    cateBLL.Insert(
                       new Category()
                       {
                           Name = txtName.Text,
                           Description = txtDesc.Text,
                           ImagePath = path,
                           Meta_Description = txtMetaDesc.Text,
                           Meta_Keyword = txtKeyword.Text,
                           Status = rblStatus.SelectedValue.ToString() == "1" ? true : false
                       });
                    img_upload.SaveAs(Server.MapPath(path));
                    Response.Redirect("/AdminCP/Categories/List.aspx");
                }
            }

        }
    }
}
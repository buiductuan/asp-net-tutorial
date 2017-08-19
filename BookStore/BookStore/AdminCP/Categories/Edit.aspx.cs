using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
namespace BookStore.AdminCP.Categories
{
    public partial class Edit : System.Web.UI.Page
    {
        private CateBLL cateBLL = new CateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                long id = long.Parse(Request.QueryString["id"].ToString());

                var _record = cateBLL.getByID(id);
                txtName.Text = _record.Name;
                txtDesc.Text = _record.Description;
                img_preview.Src = _record.ImagePath;
                txtKeyword.Text = _record.Meta_Keyword;
                if (_record.Status == true)
                    rblStatus.SelectedIndex = 1;
                rblStatus.SelectedIndex = 0;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            long id = long.Parse(Request.QueryString["id"].ToString());
            var old = cateBLL.getByID(id);
            string path = old.ImagePath;
            if (txtName.Text != "")
            {
                if (img_upload.HasFile)
                {
                    path = "/assets/upload/images/category/" + img_upload.FileName;
                    cateBLL.Update(
                       new Category()
                       {
                           ID = id,
                           Name = txtName.Text,
                           Description = txtDesc.Text,
                           ImagePath = path,
                           Meta_Description = txtMetaDesc.Text,
                           Meta_Keyword = txtKeyword.Text,
                           Status = rblStatus.SelectedValue == "1" ? true : false
                       });

                    img_upload.SaveAs(Server.MapPath(path));
                }
                else
                {
                    cateBLL.Update(
                       new Category()
                       {
                           ID = id,
                           Name = txtName.Text,
                           Description = txtDesc.Text,
                           ImagePath = path,
                           Meta_Description = txtMetaDesc.Text,
                           Meta_Keyword = txtKeyword.Text,
                           Status = rblStatus.SelectedValue == "1" ? true : false
                       });
                }
            }
        }
    }
}
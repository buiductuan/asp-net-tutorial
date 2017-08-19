using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADO_NET.database;
using ADO_NET.entities;
namespace ADO_NET
{
    public partial class Edit : System.Web.UI.Page
    {
        private config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                _rptListData.DataSource = db.getListData("SELECT [ID],[Name],[Status] FROM [Category]");
                _rptListData.DataBind();

                long id = long.Parse(Request.QueryString["id"].ToString());
                Category cate = db.getARecord(id);
                txtName.Text = cate.Name;
                if (cate.Status == true)
                    rdlStatus.SelectedIndex = 1;
                else
                    rdlStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
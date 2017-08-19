using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADO_NET.database;
namespace ADO_NET
{
    public partial class Default : System.Web.UI.Page
    {
        private config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _rptListData.DataSource = db.getListData("SELECT [ID],[Name],[Status] FROM [Category]");
                _rptListData.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                try
                {
                    string SQL = "INSERT INTO [Category](Name,Status) VALUES ('" + txtName.Text + "','" + rdlStatus.SelectedValue + "')";
                    db.ExecuteNonQuery(SQL);
                    Response.Redirect("/");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Name is not empty');</script>");
            }
        }
    }
}
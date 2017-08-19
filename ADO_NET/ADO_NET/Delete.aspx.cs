using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADO_NET.database;
namespace ADO_NET
{
    public partial class Delete : System.Web.UI.Page
    {
        private config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(Request.QueryString["id"].ToString());
                db.ExecuteNonQuery("DELETE FROM [Category] WHERE ID = '" + id + "'");
                Response.Redirect("/");
            }catch{}
        }
    }
}
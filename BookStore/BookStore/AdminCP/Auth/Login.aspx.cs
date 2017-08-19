using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace BookStore.AdminCP.Auth
{
    public partial class Login : System.Web.UI.Page
    {
        private AuthenticationBLL auth = new AuthenticationBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (auth.isAuth(txtEmail.Text, txtPassword.Text))
                {
                    Session["Auth"] = "checked";
                    Response.Redirect("/AdminCP");
                }
                else
                {
                    m_server.Text = "Email hoặc mật khẩu không chính xác";
                }
            }
        }
    }
}
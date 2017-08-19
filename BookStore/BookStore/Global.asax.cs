using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
namespace BookStore
{
    public class Global : System.Web.HttpApplication
    {

        void RegisterRoute(RouteCollection route)
        {
            route.MapPageRoute("danh-muc-sach", "danh-muc-sach/{title}-{cid}", "~/ListBook.aspx");
            route.MapPageRoute("chi-tiet-sach", "chi-tiet-sach/{title}-{bid}", "~/BookDetail.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoute(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Auth"] = null;
            Session["BookViewed"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
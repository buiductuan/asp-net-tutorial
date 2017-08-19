using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Faker;
namespace FakerASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFakeWord_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Response.Write((i+1)+" : "+Lorem.Paragraph()+"<br><br>");
            }
        }

        protected void btnFakeNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Response.Write((i + 1) + " : " + RandomNumber.Next() + "<br><br>");
            }
        }

        protected void btnFakePhone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Response.Write((i + 1) + " : " + Phone.Number() + "<br><br>");
            }
        }

        protected void btnFakeAddress_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Response.Write((i + 1) + " : " + Address.City()+"-"+Address.StreetAddress() + "<br><br>");
            }
        }

        protected void btnFakeConfig_Click(object sender, EventArgs e)
        {
           
        }
    }
}
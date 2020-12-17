using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int id=0;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();
            if (obj.login(ref id, usernametxt.Text, passwordtxt.Text))
            {
                Response.Redirect("Main menu.aspx?param="+id);
            }
            else
            {

            }

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("registerationWindow.aspx");
        }
    }
}
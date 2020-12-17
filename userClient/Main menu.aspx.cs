using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userClient
{
    public partial class Main_menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            idtxt.Text = Request.QueryString["param"];
        }

        protected void view_Click(object sender, EventArgs e)
        {
            Response.Redirect("personalInfo.aspx?param="+idtxt.Text);
        }
    }
}
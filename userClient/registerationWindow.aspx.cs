using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userClient
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();
            obj.register(nametxt.Text, gendercmb.SelectedValue, int.Parse(agetxt.Text),gmailtxt.Text, float.Parse(weighttxt.Text), float.Parse(bptxt.Text), usernametxt.Text, passwordtxt.Text,float.Parse(heighttxt.Text));
            Response.Redirect("startWindow.aspx");
        }
    }
}
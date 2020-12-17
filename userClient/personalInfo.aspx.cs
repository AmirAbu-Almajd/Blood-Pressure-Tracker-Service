using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userClient
{
    public partial class personalInfo : System.Web.UI.Page
    {
        string name = null, username = null, password = null, gender = null;
        double weight = 0, blood_pressure = 0;
        int age = 0;
        CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["param"]);
            obj.view_info(id, ref name, ref gender, ref age, ref weight, ref blood_pressure, ref username, ref password);
            nametxt.Text = name;
            usernametxt.Text = username;
            passwordtxt.Text = password;
            gendertxt.Text = gender;
            weighttxt.Text = weight.ToString();
            agetxt.Text = age.ToString();
            bptxt.Text = blood_pressure.ToString();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["param"]);
            obj.update_info(id, nametxt.Text, gendertxt.Text, int.Parse(agetxt.Text), float.Parse(weighttxt.Text), float.Parse(bptxt.Text), usernametxt.Text, passwordtxt.Text);
            obj.view_info(id, ref name, ref gender, ref age, ref weight, ref blood_pressure, ref username, ref password);
            nametxt.Text = name;
            usernametxt.Text = username;
            passwordtxt.Text = password;
            gendertxt.Text = gender;
            weighttxt.Text = weight.ToString();
            agetxt.Text = age.ToString();
            bptxt.Text = blood_pressure.ToString();
        }
    }
}
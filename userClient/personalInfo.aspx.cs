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
        string categoryString = null, name = null, username = null, password = null, gender = null, gmail = null;
        double weight = 0, blood_pressure = 0, height = 0;
        int age = 0;


        protected void Backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main menu.aspx?param=" + idtxt.Text);
        }

        int id = 0;
        CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                idtxt.Enabled = false;
                gendertxt.Enabled = false;
                bptxt.Enabled = false;
                id = int.Parse(Request.QueryString["param"]);
                idtxt.Text = id.ToString();
                obj.view_info(id, ref name, ref gender, ref age, ref weight, ref blood_pressure, ref username, ref password, ref height,ref gmail);
                nametxt.Text = name;
                usernametxt.Text = username;
                passwordtxt.Text = password;
                gendertxt.Text = gender;
                weighttxt.Text = weight.ToString();
                agetxt.Text = age.ToString();
                bptxt.Text = blood_pressure.ToString();
                gmailtxt.Text = gmail;
                Heighttxt.Text = height.ToString();
                bmilbl.Text = calculateBMI(weight, height).ToString();

            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["param"]);
            bool res = obj.update_info(id, nametxt.Text, int.Parse(agetxt.Text), float.Parse(weighttxt.Text), usernametxt.Text, passwordtxt.Text, float.Parse(Heighttxt.Text),gmailtxt.Text);
            if(res)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scriptkey", "Your information has been updated");
            obj.view_info(id, ref name, ref gender, ref age, ref weight, ref blood_pressure, ref username, ref password, ref height,ref gmail);
            nametxt.Text = name;
            usernametxt.Text = username;
            passwordtxt.Text = password;
            gendertxt.Text = gender;
            weighttxt.Text = weight.ToString();
            agetxt.Text = age.ToString();
            bptxt.Text = blood_pressure.ToString();
            gmailtxt.Text = gmail;
            bmilbl.Text = calculateBMI(weight, height).ToString();

        }
        public double calculateBMI(double weight, double height)
        {
            height /= 100;
            double res = weight / (height * height);
            if (res < 18.5)
                categoryString = "You're underweight";
            else if (res <= 24.9)
                categoryString = "Your weight is normal";
            else if (res <= 29.9)
                categoryString = "You're overweight";
            else
                categoryString = "You're obese";
            category.Text = categoryString;
            return res;
        }
    }
}
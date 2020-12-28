using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userClient
{
    public partial class Diet_plan : System.Web.UI.Page
    {
        int id = 0;
        string breakfast = null, lunch = null, dinner = null,notes=null,gmail=null;
        CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();


        protected void sendbtn_Click(object sender, EventArgs e)
        {
            gmail = obj.getGmail(id);
            string dietPlan = "Here's your diet plan based on your current blood pressure : \n" +
               "Breakfast : " + breakfast + "\n" +
               "Lunch : "+lunch + "\n" + 
               "Dinner : "+ dinner + "\n" +
               "Other notes : "+notes;
            bool sent = obj.sendDietPlan(gmail, dietPlan);
            if(sent)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scriptkey", "An E-mail has been sent to you with your diet plan");
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main menu.aspx?param=" + id.ToString());

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            string range = Request.QueryString["param"];
            obj.getDietPlan(range ,ref breakfast, ref lunch, ref dinner, ref notes);
            breakfast_txt.Text = breakfast;
            lunch_txt.Text = lunch;
            dinner_txt.Text = dinner;
            notes_txt.Text = notes;
        }
    }
}
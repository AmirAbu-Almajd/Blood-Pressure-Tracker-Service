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
        int id = 0;
        CRUDservice.WebService1SoapClient obj = new CRUDservice.WebService1SoapClient();
        double bps = 0, bpd = 0;
        DateTime latest = new DateTime();

        protected void Page_Load(object sender, EventArgs e)
        {
            idtxt.Text = Request.QueryString["param"];

            id = int.Parse(Request.QueryString["param"]);
            DateTime fault = new DateTime(2001, 1, 1);
            latest = obj.bpReminder(id);
            if (latest != fault)
            {
                warninglbl.Visible = true;
                warninglbl.Text = warninglbl.Text + latest.ToString();
            }
            graph.DataSource = obj.graphPlotting(id);
        }

        protected void view_Click(object sender, EventArgs e)
        {
            Response.Redirect("personalInfo.aspx?param=" + idtxt.Text);
        }

        protected void update_Click(object sender, EventArgs e)
        {
            obj.saveReading(id, float.Parse(bpstxt.Text),float.Parse(bpdtxt.Text));
            graph.DataSource = obj.graphPlotting(id);
            warninglbl.Visible = false;
        }

        protected void dietPlan_Click(object sender, EventArgs e)
        {
            obj.getLatestBP(id,ref bpd,ref bps);
            string range;
            if (bps < 100&&bpd<70)
                range = "low";
            else if (bps < 140 && bpd<90)
                range = "normal";
            else
                range = "high";
            Response.Redirect("Diet_plan.aspx?param=" + range + "&id="+id);
        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("startWindow.aspx");
        }
    }
}
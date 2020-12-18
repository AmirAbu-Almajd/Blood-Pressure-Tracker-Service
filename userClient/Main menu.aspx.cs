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

        protected void Page_Load(object sender, EventArgs e)
        {
            idtxt.Text = Request.QueryString["param"];

            id = int.Parse(Request.QueryString["param"]);
            DateTime fault = new DateTime(2001, 1, 1);
            DateTime latest = new DateTime();
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
            obj.saveReading(id, float.Parse(bptxt.Text));
            warninglbl.Visible = false;
        }
    }
}
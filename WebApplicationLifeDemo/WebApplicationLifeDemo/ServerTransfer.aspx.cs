using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class ServerTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Server.Transfer("~/ServerTransfer_result.aspx", false)  ---goes to second page without transfer data
            Server.Transfer("~/ServerTransfer_result.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //It will show error because it doesn't accept external url
            Server.Transfer("http://google.com");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //it loads second form inside firstform!!!
            Server.Execute("~/ServerTransfer_result.aspx");
            lbOutcome.Text = "You Have done it!!!!!!!!!!!!!!";
        }
    }
}
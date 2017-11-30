using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class SessionApplicationVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of applications = " + Application["NumberofApplication"]);
            Response.Write("<br/>");
            Response.Write("Number of Online Users = " + Application["NumberofSession"]);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplicationLifeDemo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //create application state variables
            Application["NumberofApplication"] = 0;
            Application["NumberofSession"] = 0;

            Application["NumberofApplication"] = (int)Application["NumberofApplication"] + 1;

        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Application["NumberofSession"] = (int)Application["NumberofSession"] + 1;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["NumberofSession"] = (int)Application["NumberofSession"] - 1;
        }

       
        }
}
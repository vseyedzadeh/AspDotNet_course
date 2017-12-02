using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeTracker
{
    public partial class DefaultwithMaster : System.Web.UI.Page
    {
        void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.QueryString["Print"] != null)
            {
                MasterPageFile = "~/Print.Master";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WebApplicationLifeDemo
{
    public partial class ServerTransfer_result : System.Web.UI.Page
    {
        //method1
        /*
         
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection previousCollection = Request.Form;
            lbName.Text = previousCollection["tbName"];
            lbEmail.Text = previousCollection["tbEmail"];
        }
        */

            //method2
        protected void Page_Load(object sender, EventArgs e)
        {

            Page previousPage = Page.PreviousPage;
            if (previousPage != null)
            {
                lbName.Text = ((TextBox)previousPage.FindControl("tbName")).Text;
                lbEmail.Text = ((TextBox)previousPage.FindControl("tbEmail")).Text;
            }
        }
    }
}
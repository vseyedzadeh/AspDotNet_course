using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class ApplicationVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Application["click"] == null)
            {
                Application["click"] = 1;
            }
            TextBox1.Text = Application["click"].ToString();
            Application["click"] = (int)Application["click"] + 1;
        }
    }
}
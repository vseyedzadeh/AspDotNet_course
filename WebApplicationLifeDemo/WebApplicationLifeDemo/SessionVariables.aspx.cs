using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class SessionVariables : System.Web.UI.Page
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
            if (Session["click"] == null)
            {
                Session["click"] = 1;
            }
            TextBox1.Text = Session["click"].ToString();
            Session["click"] = (int)Session["click"] + 1;
        }
    }
}
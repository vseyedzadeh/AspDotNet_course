using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class HTTPStateLess : System.Web.UI.Page
    {
        public int numberOfClick = 0;
        protected void Page_Load(object sender, EventArgs e)
        {            
            //check if it's main load or not
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            numberOfClick++;
            TextBox1.Text = numberOfClick.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace videoRentalStore
{
    public partial class DefaulMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
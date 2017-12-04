using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace videoRentalStore
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DtlViewCustomer_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            var id = CustomerDetailsViewDS.ID;
            Server.Transfer("RentMedia.aspx", true);
        }
    }
}
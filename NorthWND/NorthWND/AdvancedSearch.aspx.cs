using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthWND
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            //remove selection row in new search
            GridCustomer.SelectRow(-1);

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerListDS.SelectCommand = "SELECT * FROM [Customers] WHERE ([" + ddlField.SelectedValue + "] = @CustomerID)";

        }

    }
}
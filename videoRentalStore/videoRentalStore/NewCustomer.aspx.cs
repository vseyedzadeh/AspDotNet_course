using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using videoRentalStore.Models;

namespace videoRentalStore
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        VideoRentalStoreRepository VideoRentalStoreRepository = new VideoRentalStoreRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnAddcustomer_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                VideoRentalStoreRepository.AddNewCustomer(tbfirstName.Text, tbLastName.Text, tbAddress.Text, tbPhoneNumber.Text);
                Server.Transfer("Default.aspx");
            }
        }
    }
}
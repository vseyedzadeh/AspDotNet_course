using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckOutPage
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void chSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chSameAddress.Checked)
            {
                tbShAddress.Enabled = false;
                tbShCity.Enabled = false;
                tbShZipCode.Enabled = false;
                ddlShState.Enabled = false;
                vldRqShAdrState.Enabled = false;
            }
            else
            {
                tbShAddress.Enabled = true;
                tbShCity.Enabled = true;
                tbShZipCode.Enabled = true;
                ddlShState.Enabled = true;
            }
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (IsValid)
            {
                string contactInfo = "<b>First Name:</b> " + tbFirstName.Text + "<br/><br/>" +
                    "<b>Last Name: </b>" + tbLastName.Text + "<br/><br/>" +
                    "<b>Email Address:</b> " + tbEmail.Text + "<br /><br/>" +
                    "<b>Phone Number:</b>" + tbPhoneNumber.Text;
                string billingAddress = tbBlAddress.Text + ", " + tbBlCity.Text + ", " + ddlBlState.SelectedValue.ToString() +
                                        ", " + tbBlZipCode.Text;
                string shippingAddress = (chSameAddress.Checked) ? billingAddress : tbShAddress.Text + ", " +
                                         tbShCity.Text + ", " + ddlShState.SelectedValue.ToString() + ", " + tbShZipCode.Text;
                lblPrint.Text = "<h3>Contact Information:</h3><p>" + contactInfo + "</p>" +
                                "<h3>Billing Address:</h3><p>" + billingAddress + "</p>" +
                                "<h3>Shipping Address:</h3><p>" + shippingAddress + "<p>";
            }             
        }
    }
}
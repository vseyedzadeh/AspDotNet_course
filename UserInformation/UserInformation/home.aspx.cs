using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInformation
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            tbName.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                String newUser = getData();
                lblResult.Text = newUser;
                lbUser.Items.Add(newUser);
                lblCount.Text = countUpdate().ToString();
                clearForm();
            }
        }
        /*
         * This method clear the form
         * */
         private void clearForm()
        {
            tbName.Text = "";
            tbDOB.Text = "";
            tbEmail.Text = "";
            ddlProvince.SelectedIndex = 0;
            ddlCity.Items.Clear();
        }
        /*
         * 
         * Update the hidden counter
         * */
        private int countUpdate()
        {
            int count = int.Parse(hiddenCount.Value.ToString());
            count++;
            hiddenCount.Value = count.ToString();
            return count;
        }
        /* This method gets all the data from user form
         *  notes:
         * Missing city (to be developed) done
         * city to be checked
         * */

        private string getData()
        {
            string name = tbName.Text;
            string dob = tbDOB.Text;
            string email = tbEmail.Text;
            string city = ddlCity.SelectedValue;
            string province = ddlProvince.SelectedValue;

            return (name + ", " + dob + ", " + email + ", " + city + province);
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = ddlProvince.SelectedValue;
            ddlCity.Items.Clear();
            if (province.Equals("Quebec"))
            {
                ddlCity.Items.Add("Montreal");
                ddlCity.Items.Add("Quebec City");
                ddlCity.Items.Add("Other");
            }
            else if (province.Equals("Ontario"))
            {
                ddlCity.Items.Add("Ottawa");
                ddlCity.Items.Add("Toronto");
                ddlCity.Items.Add("Other");
            }
            else if (province.Equals("Alberta"))
            {
                ddlCity.Items.Add("Calgary");
                ddlCity.Items.Add("Toronto");
                ddlCity.Items.Add("Other");
            }
            else
            {

            }
        }
    }
}
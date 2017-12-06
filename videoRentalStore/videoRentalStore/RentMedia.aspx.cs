using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using videoRentalStore.Models;

namespace videoRentalStore
{
    public partial class RentMedia : System.Web.UI.Page
    {
        VideoRentalStoreRepository VideoRentalStoreRepository = new VideoRentalStoreRepository();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["RMID"] == null)
            {
                btnAddtoRentalList.Visible = false;
                lblMessaage.Text = "You have to go to page <a href='Customers.aspx' >customer </a>and choose a customer";
            }           
            
        }

        protected void btnAddtoRentalList_Click(object sender, EventArgs e)
        {
            List<int> rentalSelectedList = new List<int>();
            foreach (ListItem item in chbMediaList.Items)
                if (item.Selected) rentalSelectedList.Add(Int32.Parse(item.Value));

            if (rentalSelectedList.Count == 0)
            {
                lblMessaage.Text = "No media is selected";
            }
            else
            {
                int customerId = Convert.ToInt32(Request.QueryString["RMID"]);

                VideoRentalStoreRepository.AddRentalRecord(DateTime.Now, rentalSelectedList, customerId);

                Server.Transfer("default.aspx");
            }

        }

        protected void chbMediaList_DataBound(object sender, EventArgs e)
        {
            if (chbMediaList.Items.Count == 0)
                lblMessaage.Text = "No Media is found";
            else
                lblMessaage.Text = "";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using videoRentalStore.Models;

namespace videoRentalStore
{
    public partial class NewMedia : System.Web.UI.Page
    {
        VideoRentalStoreRepository VideoRentalStoreRepository = new VideoRentalStoreRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAddMedia_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (Page.IsValid)
            {
                VideoRentalStoreRepository.AddNewMedia(tbTitle.Text, ddlType.SelectedValue.ToString(), tbProductionYear.Text);
                Server.Transfer("Default.aspx");
            }

        }
    }
}
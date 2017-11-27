using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvestmentCalculateor
{
    public partial class QuotationBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid) {
                Decimal price = decimal.Parse(tbPrice.Text) * decimal.Parse(tbPrice.Text) / 100;

                lblDscamount.Text = price .ToString();
                lblTotal.Text = (price - decimal.Parse(lblDscamount.Text)).ToString();
            }
            
        }
    }
}
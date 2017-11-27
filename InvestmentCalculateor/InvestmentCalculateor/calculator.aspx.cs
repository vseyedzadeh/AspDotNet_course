using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvestmentCalculateor
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                for (int i = 50; i <= 500; i++)
                {
                    dpMonthlyValues.Items.Add(i.ToString());
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            dpMonthlyValues.SelectedIndex = 0;
            tbIntRate.Text = "1";
            tbNumYears.Text = "1";
            lblValue.Text = " ";
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal futureValue = 0;
            if (IsValid)
            {
                {
                    int monthlyInvestmtn = Int32.Parse(dpMonthlyValues.SelectedValue);
                    decimal interestRate = Convert.ToDecimal(tbIntRate.Text) / 12 / 100;
                    //int 
                    //decimal futureValue = 0;
                    for (int i = 0; i < monthlyInvestmtn; i++)
                    {
                        futureValue = (futureValue + monthlyInvestmtn) * (1 + interestRate);
                    }

                }

            }


        }
    }
}

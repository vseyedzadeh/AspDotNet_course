using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (IsValid)
            {
                string stInfo = tbName.Text + ";" + tbEmail.Text + ";" + tbDateBirth.Text + ";" + ddlClass.SelectedValue.ToString() + ";";
                lbxStudentInfo.Items.Add(stInfo);

                lbxGrade.Items.Add(tbFinalGrade.Text);

                int i = 0; decimal sum = 0;
                // decimal averageGrade = 0;

                while (i < lbxGrade.Items.Count)
                {
                    sum += Convert.ToDecimal(lbxGrade.Items[i++].ToString());
                }

                lblClassAverage.Text = Convert.ToString((decimal)sum / i);
                clearData();
            }
        }

        public void clearData()
        {
            tbName.Text = "";
            tbEmail.Text = "";
            tbConfirmEmail.Text = "";
            tbDateBirth.Text = "";
            tbFinalGrade.Text = "";
            

        }
    }
}
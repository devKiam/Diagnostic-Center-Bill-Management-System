using Mid_Term_WebApplicaiton.Classes;
using Mid_Term_WebApplicaiton.ManagingClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mid_Term_WebApplicaiton
{
    public partial class Payment_WebForm : System.Web.UI.Page
    {
        Payment_handler aPayment_handler = new Payment_handler();

        protected void Page_Load(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            amountInput.Text = "";
            dueDateInput.Text = "";

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (billNoInput.Text != "" || mobileNoInput.Text != "")
            {
                Due_view aDue_view = new Due_view();
                aDue_view = aPayment_handler.Get_due(billNoInput.Text, mobileNoInput.Text);

                if (aDue_view != null)
                {
                    Session["patientId"] = aDue_view.patient_id;
                    amountInput.Text = aDue_view.amount;
                    dueDateInput.Text = aDue_view.due_date;
                }
                else
                {
                    outputLabel.ForeColor = Color.Red;
                    outputLabel.Text = "No Unpaid bill information found For this Bill No/Mobile No !";
                }
            }
            else
            {
                amountInput.Text = "";
                dueDateInput.Text = "";
                outputLabel.ForeColor = Color.Brown;
                outputLabel.Text = "Please insert Bill No or Mobile No";
            }
        }

        protected void payButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = aPayment_handler.Make_payment(Convert.ToInt32(Session["patientId"]));
            Session["patientId"] = null;
        }
    }
}
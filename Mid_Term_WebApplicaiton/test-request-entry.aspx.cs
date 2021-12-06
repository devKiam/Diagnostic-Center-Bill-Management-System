using iTextSharp.text;
using iTextSharp.text.pdf;
using Mid_Term_WebApplicaiton.Classes;
using Mid_Term_WebApplicaiton.DabaseClasses;
using Mid_Term_WebApplicaiton.ManagingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Mid_Term_WebApplicaiton
{
    public partial class Test_Request_Entry_WebForm : System.Web.UI.Page
    {
        Test_request_handler aTest_request_handler = new Test_request_handler();
        Test_request_database_class testing = new Test_request_database_class();
        Test_handler aTest_handler = new Test_handler();
        private List<Test> testList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                testTypeDropDown.DataSource = aTest_handler.GetAllTest();
                testTypeDropDown.DataTextField = "test_name";
                testTypeDropDown.DataValueField = "test_id";
                testTypeDropDown.DataBind();
                testTypeDropDown.Items.Insert(0, new ListItem("Select Test Name", "0"));
      
            }

        }

        protected void testTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testTypeDropDown.SelectedIndex == 0)
            {
                feeTextBox.Text = "0";
            }
                
            else
            {
                feeTextBox.Text = aTest_request_handler.Get_fee(Convert.ToInt32(testTypeDropDown.SelectedValue));
                //feeTextBox.Text = testing.Get_fee(1);
                //displayLabel.Text = testing.Get_fee(1);
            }


                
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";

            Test aTest = new Test();

            aTest.test_id = Convert.ToInt32(testTypeDropDown.SelectedValue);
            aTest.test_name = testTypeDropDown.SelectedItem.Text;
            aTest.fee = Convert.ToDouble(feeTextBox.Text);

            if(Session["TempTest"] == null)
            {
                testList = new List<Test>();
            }
            else
            {
                testList = (List<Test>)Session["TempTest"];
            }

            testList.Add(aTest);

            testRequestGridView.DataSource = testList;
            testRequestGridView.DataBind();

            Session["TempTest"] = testList;

            double sum = 0;
            
            for (int i = 0; i < testRequestGridView.Rows.Count; i++)
            {
                sum += Double.Parse(testRequestGridView.Rows[i].Cells[2].Text);
            }

            totalTextBox.Text = sum.ToString();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Patient aPatient = new Patient();
            aPatient.name = patientNameTextBox.Text;
            aPatient.date_of_birth = dateOfBirthTextBox.Value;
            aPatient.mobile_no = mobileNoTextBox.Text;
            aPatient.bill_amount = Convert.ToDouble(totalTextBox.Text);
            aPatient.payment_status = 0;

            string date = DateTime.Now.ToString("yyyy-MM-dd");

            if (aTest_request_handler.Save_patient(aPatient) != "This number is already registered. Please use another mobile no. !")
            {
                foreach (Test anyTest in (List<Test>)Session["TempTest"])
                {
                    Test_request aTest_request = new Test_request();
                    aTest_request.patient_id = aTest_request_handler.Get_patient_id(aPatient.mobile_no);
                    aTest_request.test_id = anyTest.test_id;
                    aTest_request.entry_date = date;

                    displayLabel.Text = aTest_request_handler.Save_test_request(aTest_request);

                }

                PDF_handler aPDF_handler = new PDF_handler();
                Document pdfDocument = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
                PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

                pdfDocument.Open();
                pdfDocument.Add(aPDF_handler.GetBillPdfParagraph(date, aTest_request_handler.Get_patient_id(aPatient.mobile_no), aPatient.name, aPatient.date_of_birth, aPatient.mobile_no, testRequestGridView, totalTextBox.Text));
                pdfDocument.Close();

                patientNameTextBox.Text = string.Empty;
                dateOfBirthTextBox.Value = string.Empty;
                mobileNoTextBox.Text = string.Empty;
                testRequestGridView.DataSource = null;
                testRequestGridView.DataBind();
                Session["TempTest"] = null;
                totalTextBox.Text = String.Empty;
                testTypeDropDown.ClearSelection();

                Response.ContentType = "application/pdf";
                Response.AppendHeader("content-disposition", "attachment;filename=Bill.pdf");
                Response.Write(pdfDocument);
                Response.Flush();
                Response.End();

            }
            else
            {
                displayLabel.Text = "This number is already registered. Please use another mobile no. !";
            }
        }
    }
}
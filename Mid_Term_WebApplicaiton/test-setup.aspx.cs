using Mid_Term_WebApplicaiton.ManagingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mid_Term_WebApplicaiton
{
    public partial class Test_Setup_WebForm : System.Web.UI.Page
    {
        Test_handler aTest_handler = new Test_handler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                testTypeDropDownList.DataSource = aTest_handler.GetAllTestTypes();
                testTypeDropDownList.DataTextField = "type_name";
                testTypeDropDownList.DataValueField = "test_type_id";
                testTypeDropDownList.DataBind();
                testTypeDropDownList.Items.Insert(0, new ListItem("Select Test Type", "0"));
            }
            

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Test aTest = new Test();
            aTest.test_name = testNameTextBox.Text;
            aTest.fee = Double.Parse(feeTextBox.Text);
            aTest.test_type_id = Convert.ToInt32(testTypeDropDownList.SelectedValue);
            displayLabel.Text = aTest_handler.save_test(aTest);

            testNameTextBox.Text = string.Empty;
            feeTextBox.Text = string.Empty;

            testSetupGridView.DataSource = aTest_handler.GetAllTest();
            testSetupGridView.DataBind();

            testTypeDropDownList.ClearSelection();
        }
    }
}
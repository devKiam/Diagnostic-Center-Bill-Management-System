using Mid_Term_WebApplicaiton.ManagingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mid_Term_WebApplicaiton
{
    public partial class Test_Type_Setup_WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Test_type aTest_type = new Test_type();
            aTest_type.type_name = typeNameTextBox.Text;

            Test_handler aTest_handler = new Test_handler();
            messageLabel.Text = aTest_handler.Save_Test_Type(aTest_type);
            typeNameTextBox.Text = string.Empty;


            TestTypeGridView.DataSource = aTest_handler.GetAllTestTypes();
            TestTypeGridView.DataBind();

        }
    }
}
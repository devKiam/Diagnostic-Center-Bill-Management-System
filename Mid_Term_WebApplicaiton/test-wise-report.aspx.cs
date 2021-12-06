using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Test_Wise_Report_WebForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Report_handler aReport_handler = new Report_handler();
            testWiseReportGridView.DataSource = aReport_handler.Get_test_wise_report_view(fromDateTextBox.Value, toDateTextBox.Value);
            testWiseReportGridView.DataBind();

            //int a = testWiseReportGridView.Rows.Count;
            //Console.WriteLine($"{a}");

            double total = 0;
            for (int i = 0; i < testWiseReportGridView.Rows.Count; i++)
            {
                try
                {
                    total += Double.Parse(testWiseReportGridView.Rows[i].Cells[3].Text);
                }
                catch
                {
                    continue;
                }
               
            }
            totalTextBox.Text = (total).ToString();
            totalTextBox.ForeColor = Color.Red;
        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
            PDF_handler aPdf_handler = new PDF_handler();
            Document pdfDocument = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(aPdf_handler.GetTestWiseReportPdfParagraph(fromDateTextBox.Value, toDateTextBox.Value, testWiseReportGridView, totalTextBox.Text));
            pdfDocument.Close();

            fromDateTextBox.Value = string.Empty;
            toDateTextBox.Value = string.Empty;
            testWiseReportGridView.DataSource = null;
            testWiseReportGridView.DataBind();
            totalTextBox.Text = String.Empty;

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "attachment;filename=TestWiseReport.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}
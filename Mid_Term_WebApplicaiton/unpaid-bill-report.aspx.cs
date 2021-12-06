using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Unpaid_Bill_Report_WebForm : System.Web.UI.Page
    {
        Report_handler aReport_handler = new Report_handler();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            unpaidBillReportGridView.DataSource = aReport_handler.Get_unpaid_bill_report_view(fromDateTextBox.Value, toDateTextBox.Value);
            unpaidBillReportGridView.DataBind();

            double sum = 0;
            for (int i = 0; i < unpaidBillReportGridView.Rows.Count; i++)
            {
                try
                {
                    sum += Double.Parse(unpaidBillReportGridView.Rows[i].Cells[4].Text);
                }
                catch
                {
                    continue;
                }
                
            }
            totalTextBox.Text = sum.ToString();
            totalTextBox.ForeColor = Color.Red;
        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
            PDF_handler aPdfManager = new PDF_handler();
            Document pdfDocument = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(aPdfManager.GetUnpaidBillReportPdfParagraph(fromDateTextBox.Value, toDateTextBox.Value, unpaidBillReportGridView, totalTextBox.Text));
            pdfDocument.Close();

            fromDateTextBox.Value = string.Empty;
            toDateTextBox.Value = string.Empty;
            unpaidBillReportGridView.DataSource = null;
            unpaidBillReportGridView.DataBind();
            totalTextBox.Text = String.Empty;

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "attachment;filename=UnpaidBillReport.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}
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
    public partial class Type_Wise_Report_WebForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Report_handler aReport_handler = new Report_handler();
            typeWiseReportGridView.DataSource = aReport_handler.Get_type_wise_report_view(fromDateTextBox.Value, toDateTextBox.Value);
            typeWiseReportGridView.DataBind();

            double total = 0;
            for (int i = 0; i < typeWiseReportGridView.Rows.Count; i++)
            {
                try
                {
                    total += Double.Parse(typeWiseReportGridView.Rows[i].Cells[3].Text);
                }
                catch
                {
                    typeWiseReportGridView.Rows[i].Cells[3].Text = "0";
                    continue;
                }
                
            }
            totalTextBox.Text = (total).ToString();
            totalTextBox.ForeColor = Color.Red;
        }

        protected void pdfButton_Click(object sender, EventArgs e)
        {
            PDF_handler aPdfManager = new PDF_handler();
            Document pdfDocument = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(aPdfManager.GetTypeWiseReportPdfParagraph(fromDateTextBox.Value, toDateTextBox.Value, typeWiseReportGridView, totalTextBox.Text));
            pdfDocument.Close();

            fromDateTextBox.Value = string.Empty;
            toDateTextBox.Value = string.Empty;
            typeWiseReportGridView.DataSource = null;
            typeWiseReportGridView.DataBind();
            totalTextBox.Text = String.Empty;

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "attachment;filename=TypeWiseReport.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}
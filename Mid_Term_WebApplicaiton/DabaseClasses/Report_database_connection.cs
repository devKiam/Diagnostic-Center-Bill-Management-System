using Mid_Term_WebApplicaiton.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.DabaseClasses
{
    public class Report_database_connection:Connection_database_class
    {
        public List<Test_wise_report_view> Get_test_wise_report_view(string from_date, string to_date)
        {
            query = "SELECT ti.TestName,ti.Fee, COUNT(tr.TestId) AS NoOfTest, (Fee*COUNT(tr.TestId)) AS TotalAmount FROM Test AS ti LEFT JOIN TestRequest AS tr ON ti.TestId=tr.TestId WHERE tr.EntryDate BETWEEN '" + from_date + "' AND '" + to_date + "' OR tr.EntryDate IS NULL GROUP BY ti.TestName, ti.Fee";
            List<Test_wise_report_view> Test_wise_report_list = new List<Test_wise_report_view>();
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Test_wise_report_view aTestWiseReport = new Test_wise_report_view();
                aTestWiseReport.test_name = reader["TestName"].ToString();
                aTestWiseReport.no_of_test = reader["NoOfTest"].ToString();
                aTestWiseReport.total_amount = reader["TotalAmount"].ToString();

                Test_wise_report_list.Add(aTestWiseReport);
            }
            reader.Close();
            connection.Close();
            return Test_wise_report_list;
        }

        public List<Type_wise_report_view> Get_type_wise_report_view(string from_date, string to_date)
        {
            query = "SELECT a.TestType , Sum(a.NoOfTest) AS NoOfTest , Sum(a.TotalAmount) AS TotalAmount FROM (SELECT tyi.TestType, Count(tr.testId) As NoOfTest, (Fee*Count(tr.testId)) As TotalAmount From TestType AS tyi Left Outer Join Test AS ti ON tyi.TestTypeId = ti.TestTypeId Left Outer Join TestRequest tr ON ti.TestId = tr.TestId WHERE EntryDate BETWEEN '" + from_date + "' AND '" + to_date + "' OR EntryDate IS NULL GROUP BY tyi.TestType, Fee) a GROUP BY a.TestType";
            List<Type_wise_report_view> Type_wise_report_view = new List<Type_wise_report_view>();
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Type_wise_report_view aTypeWiseReport = new Type_wise_report_view();
                aTypeWiseReport.test_type = reader["TestType"].ToString();
                aTypeWiseReport.no_of_test = reader["NoOfTest"].ToString();
                aTypeWiseReport.total_amount = reader["TotalAmount"].ToString();

                Type_wise_report_view.Add(aTypeWiseReport);
            }
            reader.Close();
            connection.Close();
            return Type_wise_report_view;
        }

        public List<Unpaid_bill_report_view> Get_unpaid_bill_report_list(string from_date, string to_date)
        {
            query = "SELECT p.PatientId AS BillNo, Name, MobileNo, BillAmount, COUNT(*) " +
                    "FROM Patient AS p LEFT JOIN TestRequest AS tr " +
                    "ON p.PatientId=tr.PatientId " +
                    "WHERE PaymentStatus='0' AND tr.EntryDate BETWEEN '" + from_date + "' AND '" + to_date + "' " +
                    "GROUP BY p.PatientId, Name, MobileNo, BillAmount";
            List<Unpaid_bill_report_view> Unpaid_bill_report_list = new List<Unpaid_bill_report_view>();
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Unpaid_bill_report_view aReportView = new Unpaid_bill_report_view();
                aReportView.bill_no = reader["BillNo"].ToString();
                aReportView.name = reader["Name"].ToString();
                aReportView.mobile_no = reader["MobileNo"].ToString();
                aReportView.bill_amount = reader["BillAmount"].ToString();
                Unpaid_bill_report_list.Add(aReportView);
            }
            reader.Close();
            connection.Close();
            return Unpaid_bill_report_list;
        }
    }
}
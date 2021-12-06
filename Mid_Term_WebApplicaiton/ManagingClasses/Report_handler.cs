using Mid_Term_WebApplicaiton.Classes;
using Mid_Term_WebApplicaiton.DabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.ManagingClasses
{
    public class Report_handler
    {
        Report_database_connection aReport_database_connection = new Report_database_connection();

        public List<Test_wise_report_view> Get_test_wise_report_view(string from_date, string to_date)
        {
            return aReport_database_connection.Get_test_wise_report_view(from_date, to_date);
        }

        public List<Type_wise_report_view> Get_type_wise_report_view(string from_date, string to_date)
        {
            return aReport_database_connection.Get_type_wise_report_view(from_date, to_date);
        }

        public List<Unpaid_bill_report_view> Get_unpaid_bill_report_view(string from_date, string to_date)
        {
            return aReport_database_connection.Get_unpaid_bill_report_list(from_date, to_date);
        }
    }
}
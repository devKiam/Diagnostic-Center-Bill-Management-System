using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton
{
    public class Patient
    {
        public int patient_id { get; set; }
        public string name { get; set; }
        public string date_of_birth { get; set; }
        public string mobile_no { get; set; }
        public double bill_amount { get; set; }
        public int payment_status { get; set; }

        public Bill patient_bill;
        public List<Test> patient_tests_list;

        public Patient()
        {
            patient_tests_list = new List<Test>();
        }
    }
}

using Mid_Term_WebApplicaiton.Classes;
using Mid_Term_WebApplicaiton.DabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.ManagingClasses
{
    public class Payment_handler
    {
        private Payment_database_class aPayment_database_class = new Payment_database_class();

        public Due_view Get_due(string bill_no, string mobile_no)
        {
            return aPayment_database_class.Get_due(bill_no, mobile_no);
        }

        public string Make_payment(int patient_id)
        {
            int rowAffected = aPayment_database_class.Make_payment(patient_id);
            if (rowAffected > 0)
                return "Payment Successful";
            else
                return "Sorry, payment is not successful !";
        }
    }
}
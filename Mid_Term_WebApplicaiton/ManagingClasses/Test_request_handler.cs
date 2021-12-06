using Mid_Term_WebApplicaiton.Classes;
using Mid_Term_WebApplicaiton.DabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.ManagingClasses
{
    public class Test_request_handler
    {
        Test_request_database_class aTest_request_database_class = new Test_request_database_class();

        public string Save_patient(Patient aPatient)
        {
            if (aTest_request_database_class.Check_patient(aPatient))
            {
                return "This number is already registered. Please use another mobile no. !";
            }
            else
            {
                int rowAffacted = aTest_request_database_class.Save_patient(aPatient);
                if (rowAffacted > 0)
                    return "Patient Information saved.";
                else
                    return "Sorry, Patient Information saved failed !";
            }
        }


        public string Get_fee(int test_id)
        {
            return aTest_request_database_class.Get_fee(test_id);
        }

        public int Get_patient_id(string mobile_no)
        {
            return aTest_request_database_class.Get_patient_id(mobile_no);
        }

        public string Save_test_request(Test_request aTest_request)
        {
            int rowAffacted = aTest_request_database_class.Save_test_request(aTest_request);
            if (rowAffacted > 0)
                return "Test Request Saved";
            else
                return "Sorry, Test Request failed to save !";
        }
    }
}
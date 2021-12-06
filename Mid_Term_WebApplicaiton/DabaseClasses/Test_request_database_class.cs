using Mid_Term_WebApplicaiton.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.DabaseClasses
{
    public class Test_request_database_class:Test_database_class
    {
        public bool Check_patient(Patient aPatient)
        {
            query = "SELECT * FROM Patient WHERE MobileNo = '" + aPatient.mobile_no + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool patientExists = reader.HasRows;
            reader.Close();
            connection.Close();
            return patientExists;
        }

        public int Save_patient(Patient aPatient)
        {
            query = "INSERT INTO Patient (Name, DateOfBirth, MobileNo, BillAmount, PaymentStatus) VALUES ('" + aPatient.name + "','" + aPatient.date_of_birth + "','" + aPatient.mobile_no + "','" + aPatient.bill_amount + "','" + aPatient.payment_status + "')";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public string Get_fee(int test_id)
        {
            query = "SELECT * FROM Test WHERE TestId='" + test_id + "'";
            command = new SqlCommand(query, connection);
            string fee = String.Empty;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                fee = reader["Fee"].ToString();
            }
            reader.Close();
            connection.Close();
            return fee;
        }

        public int Get_patient_id(string mobile_no)
        {
            query = "SELECT * FROM Patient WHERE MobileNo='" + mobile_no + "'";
            command = new SqlCommand(query, connection);
            int patientId = 0;
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                patientId = Convert.ToInt32(reader["PatientId"]);
            }
            reader.Close();
            connection.Close();
            return patientId;
        }

        public int Save_test_request(Test_request aTest_request)
        {
            query = "INSERT INTO TestRequest (PatientId, TestId, EntryDate) VALUES ('" + aTest_request.patient_id + "','" + aTest_request.test_id + "','" + aTest_request.entry_date + "')";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
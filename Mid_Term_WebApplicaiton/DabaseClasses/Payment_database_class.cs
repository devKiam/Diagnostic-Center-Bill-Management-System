using Mid_Term_WebApplicaiton.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Mid_Term_WebApplicaiton.DabaseClasses
{
    public class Payment_database_class:Connection_database_class
    {
        public Due_view Get_due(string bill_no, string mobile_no)
        {
            Due_view aDue_view = null;
            query = "SELECT p.PatientId, p.BillAmount, tr.EntryDate AS DueDate FROM Patient AS p JOIN TestRequest AS tr ON p.PatientId = tr.PatientId WHERE p.PaymentStatus='0' AND (p.PatientId='" + bill_no + "' OR p.MobileNo='" + mobile_no + "') ";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                aDue_view = new Due_view();
                while (reader.Read())
                {
                    aDue_view.patient_id = Convert.ToInt32(reader["PatientId"]);
                    aDue_view.amount = reader["BillAmount"].ToString(); // BillAmount from Database
                    aDue_view.due_date = reader["DueDate"].ToString(); // EntryDate from Database
                }
                reader.Close();
                connection.Close();
                return aDue_view;
            }
            else
            {
                connection.Close();
                return aDue_view;
            }
        }

        public int Make_payment(int patient_id)
        {
            query = "UPDATE Patient SET PaymentStatus='1' WHERE PatientId='" + patient_id + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffacted = command.ExecuteNonQuery();
            connection.Close();
            return rowAffacted;
        }
    }
}
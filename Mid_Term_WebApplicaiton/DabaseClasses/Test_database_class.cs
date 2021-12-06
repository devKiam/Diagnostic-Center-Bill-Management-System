using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.DabaseClasses
{
    public class Test_database_class:Connection_database_class
    {
        public int Save_test_type(Test_type aTest_type)
        {
            query = "INSERT INTO TestType (TestType) VALUES ('"+aTest_type.type_name+ "')";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public bool Check_test_type(Test_type aTest_type)
        {
            query = "SELECT * FROM TestType WHERE TestType = '" + aTest_type.type_name + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool typeNameExists = reader.HasRows;
            reader.Close();
            connection.Close();
            return typeNameExists;
        }

        //creating a list for show it into GridView.......
        public List<Test_type> GetAllTestTypes()
        {
            query = "SELECT * FROM TestType";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();

            List<Test_type> testTypes = new List<Test_type>();
            // here read table value database for wesite table.........
            while (reader.Read())
            {
                Test_type aTest_type = new Test_type();
                aTest_type.test_type_id = (int)reader["TestTypeId"];
                aTest_type.type_name = reader["TestType"].ToString();
                testTypes.Add(aTest_type);
            }

            reader.Close();
            connection.Close();
            return testTypes;
        }




        public int save_test(Test aTest)
        {
            query = "INSERT INTO Test (TestName, Fee, TestTypeId) VALUES ('" + aTest.test_name + "','" + aTest.fee + "','" + aTest.test_type_id + "')";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool check_test(Test aTest)
        {
            query = "SELECT * FROM Test WHERE TestName = '" + aTest.test_name + "'";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool testNameExists = reader.HasRows;
            reader.Close();
            connection.Close();
            return testNameExists;
        }

        public List<Test> GetAllTest()
        {
            query = "SELECT TestId, TestName, Fee, TestType FROM Test JOIN TestType ON Test.TestTypeId=TestType.TestTypeId ORDER BY TestName ASC";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();

            List<Test> testList = new List<Test>();
            while (reader.Read())
            {
                Test aTest = new Test();
                aTest.test_id = (int)reader["TestId"];
                aTest.test_name = reader["TestName"].ToString();
                aTest.fee = Convert.ToDouble(reader["Fee"]);
                aTest.test_type = reader["TestType"].ToString();

                testList.Add(aTest);
            }
            reader.Close();
            connection.Close();
            return testList;
        }
    }
}
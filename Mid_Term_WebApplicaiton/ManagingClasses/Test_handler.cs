using Mid_Term_WebApplicaiton.DabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton.ManagingClasses
{
    public class Test_handler
    {
        Test_database_class aTest_database_class = new Test_database_class();

        public string Save_Test_Type(Test_type aTest_type)
        {
            if(aTest_database_class.Check_test_type(aTest_type))
            {
                return "Type Name already exists !";
            }
            else
            {
                int rowAffected = aTest_database_class.Save_test_type(aTest_type);

                if (rowAffected >= 1)
                {
                    return "Test Type Name saved successfully";
                }
                else
                {
                    return "Test Type Name save failed !";
                }
            }
        }

        public List<Test_type> GetAllTestTypes()
        {
            return aTest_database_class.GetAllTestTypes();
        }







        public string save_test(Test aTest)
        {
            if(aTest_database_class.check_test(aTest))
            {
                return "Test Name already exists !";
            }
            else
            {
                int rowAffected = aTest_database_class.save_test(aTest);
                if(rowAffected >= 1)
                {
                    return "Test Name Saved !";

                }
                else
                {
                    return "Test Name Saved failed !";
                }
            }
        }

        public List<Test> GetAllTest()
        {
            return aTest_database_class.GetAllTest();
        }

    }
}
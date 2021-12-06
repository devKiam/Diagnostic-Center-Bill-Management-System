using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Term_WebApplicaiton
{
    public class Test_type
    {
        public int test_type_id { get; set; }
        public string type_name { get; set; }

        public List<Test> tests_list;

        public Test_type()
        {
            tests_list = new List<Test>();
        }
    }
}
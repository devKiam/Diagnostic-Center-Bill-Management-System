using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Mid_Term_WebApplicaiton.DabaseClasses
{
    public class Connection_database_class
    {
        protected string connectionSrting = @"Server=KIAM-PC-ASUS-FX\SQLEXPRESS; Database=dcmsDB; Integrated Security= True";
        public string query { get; set; }
        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }

        public Connection_database_class()
        {
            connection = new SqlConnection(connectionSrting);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePOS.modules
{
    

    class sysPublic
    {
        public static string loggedInUserName = "";
        public SqlConnection conn = new SqlConnection();
        public string StrCmd;
        public SqlCommand Cmd = new SqlCommand();
        public int loggedInActiveUserID = 0;
        public string loggedInUserAccNo = "";

        public static SqlConnection getDatabaseConnection()
        {
            string connString = "Data Source=felix;Initial Catalog=schoolManagementSys;User ID=felix;Password=felix37brock;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            return conn;
        }

    }
}

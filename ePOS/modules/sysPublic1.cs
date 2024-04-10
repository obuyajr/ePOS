using System;
using System.Data.SqlClient;

namespace ePOS.modules
{
    public class sharedData
    {
        public static string loggedInUserName = "";
        public static SqlConnection conn = new SqlConnection();
        public static string StrCmd;
        public SqlCommand Cmd = new SqlCommand();
        public int loggedInActiveUserID = 0;
        public string loggedInUserAccNo = "";


        public static SqlConnection getDatabaseConnection()
        {
            string connString = "Data Source=felix;Initial Catalog=schoolManagementSys;User ID=felix;Password=felix37brock;";
            conn.ConnectionString = connString;
            conn.Open();

            return conn;
        }
    }
}

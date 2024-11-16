using System;
using System.Configuration;
using System.Data.SqlClient;



namespace ETC_DatabaseLayer
{
    static public class clsDBSettings
    {

     public  static string ConnectionString =   string.Join(";", "Database=" + ConfigurationManager.ConnectionStrings["DBName"], "Server=" + ConfigurationManager.ConnectionStrings["Server"]
                , "User Id=" + ConfigurationManager.ConnectionStrings["User Id"], "Password=" + ConfigurationManager.ConnectionStrings["Password"]);

    }
}

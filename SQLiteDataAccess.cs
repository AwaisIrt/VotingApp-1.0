using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;


namespace VotingApp
{
    class SQLiteDataAccess
    {
       //Gets the Connection string from the App,config. Used a public method so it can be accessed throughout the application. 
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
    }
}

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
    internal class SQLiteDataAccess
    {
        public static List<User> LoadUsers()
        {
           using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
           {
                var output = cnn.Query<User>("select * from User", new DynamicParameters());
                //Remove this when carrying on
                return output.ToList();
           }
       
        }
        public static void RegisterUser(User UserRegistration)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User(FirstName, LastName) values (@FirstName, @LastName)", UserRegistration);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
    }
}

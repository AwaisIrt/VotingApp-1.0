using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        

        public string UserRegistration
        {
            get
            {
                return $"{ FirstName}{LastName}";
            }
        }
    }
}

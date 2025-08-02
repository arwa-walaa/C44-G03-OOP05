using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        // In a real application, these would come from a database
        private const string ValidUsername = "admin";
        private const string ValidPassword = "password123";
        private const string ValidRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == ValidUsername && password == ValidPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == ValidUsername && role == ValidRole;
        }
    }
}

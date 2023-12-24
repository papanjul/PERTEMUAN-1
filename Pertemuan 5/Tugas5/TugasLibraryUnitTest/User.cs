using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLibraryUnitTest
{
    public class User
    {
        static bool isValidUser(string username, string password)
        {
            bool isValid = (username == "contohuser" && password == "contohpassword");
            return isValid;
        }
    }
}

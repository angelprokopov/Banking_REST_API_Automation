using Banking_REST_API_Automation_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_REST_API_Automation_Framework.TestData
{
    public class TestUsers
    {
        public static LoginRequest ValidUser => new()
        {
            Username = "test.user",
            Password = "Password123!"
        };

        public static LoginRequest InvalidUser => new()
        {
            Username = "invalid.user",
            Password = "WrongPassword"
        };
    }
}

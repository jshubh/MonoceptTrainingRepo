using DIPRefactoredAppWithDelegates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPRefactoredAppWithDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

                ILogger logger = new ConsoleLogger();
                Func<string, string> encrypt = s => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s));

                UserManager userManager = new UserManager(logger, encrypt);
                userManager.CreateUser("johndoe", "password123");
            }
        }
    }
}

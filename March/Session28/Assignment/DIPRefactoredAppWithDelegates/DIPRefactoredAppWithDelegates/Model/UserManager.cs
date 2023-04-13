using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPRefactoredAppWithDelegates.Model
{
    internal class UserManager
    {
        private readonly ILogger logger;
        private readonly Func<string, string> encrypt;

        public UserManager(ILogger logger, Func<string, string> encrypt)
        {
            this.logger = logger;
            this.encrypt = encrypt;
        }

        public void CreateUser(string username, string password)
        {
            string encryptedPassword = encrypt(password);
            // Code to create user with username and encryptedPassword
            logger.Log($"User '{username}' created with password '{encryptedPassword}'");
        }
    }
}

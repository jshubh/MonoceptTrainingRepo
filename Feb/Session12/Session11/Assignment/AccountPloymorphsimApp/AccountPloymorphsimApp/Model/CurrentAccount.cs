using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPloymorphsimApp.Model
{
    internal class CurrentAccount:Account
    {
        private const int OVER_DRAFT_LIMIT = 5000;
        public CurrentAccount(int accno, string name, double balance) : base(accno, balance, name)
        {
        }
        public override void Withdraw(double amt)
        {
            {
                if (_balance - amt > OVER_DRAFT_LIMIT)
                    _balance = _balance - amt;
                return;
            }
            throw new Exception("No Suffiecient funds");
        }
    }
}

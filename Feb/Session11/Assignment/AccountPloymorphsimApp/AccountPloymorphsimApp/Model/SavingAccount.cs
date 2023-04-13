using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPloymorphsimApp.Model
{
    internal class SavingAccount:Account
    {
        private const int  MIN_BALANCE = 1000;
        public SavingAccount(int accno,string name,double balance):base(accno,balance,name)
        {
        }
        public override void Withdraw(double amt)
        {
            if (HashSufficient(amt))
            {

                _balance = amt;

                return;

            }
            throw new Exception("not sufficinet balance");
           
        }

        private bool HashSufficient(double amount)
        {
            return _balance - amount >= MIN_BALANCE;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventRefactoredApp.Model
{
    //delegate void DBalanceChange(Account account);
    internal class Account
    {
        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        public event Action<Account> OnBalanceChanged;

        public Account(int accouno, string name, double balance)
        {
            _accouno = accouno;
            _name = name;
            _balance = balance;
        }

        public Account(int accouno, string name)
        {
            _accouno = accouno;
            _name = name;
            _balance = MIN_BALANCE;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            if(OnBalanceChanged!= null)
            {
                OnBalanceChanged(this);
            }
        }

        public void Withdraw(double amount)
        {
            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                if (OnBalanceChanged != null)
                {
                    OnBalanceChanged(this);
                }
            }
            else
                Console.WriteLine("ERROR : No sufficient funds ");
        }
        public bool SufficientFundsAvailable(double withAmount)
        {
            double amountAfterWithdraw = _balance - withAmount;
            return amountAfterWithdraw >= MIN_BALANCE;
        }

        public double Accouno
        {
            get { return _accouno; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}

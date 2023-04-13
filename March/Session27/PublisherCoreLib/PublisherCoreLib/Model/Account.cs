using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    public class Account
    {
        private readonly   int _accno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private List<IAccountNotifier> _notigications;

        public  Account(int accno,double balance,string name)
        {
            _accno = accno;
            _balance = balance;
            _name = name;
            _notigications = new List<IAccountNotifier>();


        }
        public Account ()
        {
            _accno = (int)Accouno;
            _balance = (double)Balance;
            _name = (string)Name;

        }
        public  Account(int accno,string name)
        {
            _accno = accno;
            _name = name;
            _balance = MIN_BALANCE;


        }
        public void AddSubscriber(IAccountNotifier notifier)
        {
            _notigications.Add(notifier);
        }
        
        public void Deposit(double amount)
        {
            _balance += amount;
            foreach(IAccountNotifier notifier in _notigications)
            {
                notifier.Notify(this);
            }
        }
        public void Withdraw(double amount)
        {

            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                foreach (IAccountNotifier notifier in _notigications)
                {
                    notifier.Notify(this);
                }
            }
            else
            {
                Console.WriteLine("Error :No Funds");
            }
        }
        private bool SufficientFundsAvailable(double withAmount)
        {

            double amountAterWithdraw = _balance - withAmount;
            
                return amountAterWithdraw >= MIN_BALANCE;
        
        }
        public double Balance
        {     get{
                return _balance;

            }
        }
            public double Accouno
        {
            get
            {
                return _accno;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
       


    }
}

using AccountTransactionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        private readonly   int _accno;
        private double _balance=0;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private readonly List<Transcation> _transcations;

        public  Account(int accno,double balance,string name)
        {
            _accno = accno;
            _balance = balance;
            _name = name;
            _transcations = new List<Transcation>();
            _transcations.Add(new Transcation { Type = 'D', Amount = _balance, Time = DateTime.Now });


        }
        public Account ()
        {
            _accno = (int)Accouno;
            _balance = (double)Balance;
            _name = (string)Name;

        }
        public Account(int accno, string name):this(accno,MIN_BALANCE,name)
        {
           


        }
        
        public void Deposit(double amount)
        {
            _balance += amount;
            _transcations.Add(new Transcation { Type='D',Amount=amount,Time=DateTime.Now});
        }
        public void Withdraw(double amount)
        {

            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                _transcations.Add(new Transcation { Type = 'W', Amount =amount, Time = DateTime.Now });

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

        public List<Transcation> Transcations
        {
            get
            {
                return _transcations;
            }
        }
       
        public IEnumerable<Transcation> Transcationzz
        {
            get
            {
                return _transcations;
            }
        }

    }
}

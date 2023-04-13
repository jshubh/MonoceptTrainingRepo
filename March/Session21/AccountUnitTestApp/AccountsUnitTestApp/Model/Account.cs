using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsUnitTestApp.Model
{
    internal class Account
    {
        private readonly   int _accno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;

        public  Account(int accno,double balance,string name)
        {
            if(balance<MIN_BALANCE)
            {
                throw new Exception("Cannot created account below minimum balance");
            }
            _accno = accno;
            _balance = balance;
            _name = name;


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
        
        public void Deposit(double amount)
        {
            if (_balance > 100)
            {
                _balance += amount;
            }
            else
            {
                throw new Exception("Please Add more than 100");
            }
        }
        public void Withdraw(double amount)
        {

            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
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

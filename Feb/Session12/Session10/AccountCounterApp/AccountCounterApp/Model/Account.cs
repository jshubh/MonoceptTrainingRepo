using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp.Model
{
    internal class Account
    {
        private readonly   int _accno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private  static int _instanceCount = 0;

        public  Account(int accno,double balance,string name)
        {
            _accno = accno;
            _balance = balance;
            _name = name;
            _instanceCount+= 1;

        }
        static Account()
        {
            _instanceCount = 100;
            Console.WriteLine("inside static Constructor");
        }
        
        public  Account(int accno,string name):this(accno,MIN_BALANCE,name)
        {


        }
        
        public void Deposit(double amount)
        {
            _balance += amount;
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
       public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public static int HeadCount()
        {
            return _instanceCount;
        }


    }
}

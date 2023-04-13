using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPloymorphsimApp.Model
{
    internal abstract class Account
    {
        private readonly int _accno;
        protected double _balance;
        private readonly string _name;
       

        public Account(int accno, double balance, string name)
        {
            _accno = accno;
            _balance = balance;
            _name = name;


        }
       
        public abstract void Withdraw(double amt);
            
    
        
        public void Deposit(double amount)
        {
            _balance += amount;
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

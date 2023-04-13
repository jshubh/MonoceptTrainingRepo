﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConsoleApp
{
    public class Account
    {
        private readonly   int _accno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;

        public  Account(int accno,double balance,string name)
        {
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
       


    }
}

using AccountsUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsUnitTestApp
{
    [TestClass]
    public class AccountTest
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        
        
        public void ShouldCreateAccountName()
        {
            double expecptedBalnce = 500;
            string expectedName="ShuBh";
            int expectAccno = 101;
            double expectedWithdraw = 300;
           
            double expectDeposit = 200;
          
            Account acc1 = new Account(101, 484, "Shubh");
            acc1.Deposit(100);
            
            double actualBalanceAvailableforWithdraw = acc1.Balance;
            
            Assert.AreEqual(expectedName, acc1.Name);
            Assert.AreEqual(expecptedBalnce, acc1.Balance);
            Assert.AreEqual(expectAccno, acc1.Accouno);
            
        }
        public void ShouldCheckIfSuffiecientBalance()
        {
            Account acc1 = new Account(101, 484, "Shubh");
            double expectedWithDrawBalance = 1000;

            double actualBalanceAvailableforWithdraw = acc1.Balance;
            
            Assert.AreEqual(expectedWithDrawBalance,actualBalanceAvailableforWithdraw);
        }
        public void ShouldCheckIfDepositAmount()
        {
            Account acc1 = new Account(101, 484, "Shubh");
            acc1.Deposit(200);
            double expectedDeposit = 1000;

            

            Assert.AreEqual(expectedDeposit,);
        }


    }
}

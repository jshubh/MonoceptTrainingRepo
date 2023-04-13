using EmployeeApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeePloymorphismTestApp
{
   
        [TestClass]
        public class EmployeePloymorphismTest
        {
            [TestMethod]
            public void Create_ManagerDetailToCheckResult()
            {
                int expectedId = 101;
                string expectedName = "rohan";
                double expectedBasicSalary = 6000;
                Manager manager = new Manager(101, "rohan", 6000);
                Assert.AreEqual(expectedId, manager.Id);
                Assert.AreEqual(expectedName, manager.Name);
                Assert.AreEqual(expectedBasicSalary, manager.BasicSalary);
            }
            [TestMethod]
            public void Create_ManagerDetailToCheckCostOfCompanyOfResult()
            {
                double expectedCTC = 25200;
                double expectedHouseRentAllowane = 600;
                double expectedTravelingAllowance = 500;
                Manager manager = new Manager(101, "rohan", 1000);
                double actualCTC = manager.CostToCompany;
                Assert.AreEqual(expectedCTC, actualCTC);
                Assert.AreEqual(expectedHouseRentAllowane, manager.HouseRentAllowance);
                Assert.AreEqual(expectedTravelingAllowance, manager.TravellingAllowance);
            }
            [TestMethod]
            public void Create_ManagerSalaryBreakUpAndRole()
            {
                string expectedSalaryBreakup = "houserent allowance:" + 600 +
                    "Travelling Allowance:" + 500;
                string expectedRole = "Manager";
                Manager manager = new Manager(101, "rohan", 1000);
                Assert.AreEqual(expectedSalaryBreakup, manager.SalaryBreakUp);
                Assert.AreEqual(expectedRole, manager.Role);
            }

            [TestMethod]
            public void Create_DeveloperDetailToCheckResult()
            {
                int expectedId = 101;
                string expectedName = "rohan";
                double expectedBasicSalary = 6000;
                Developer developer = new Developer(101, "rohan", 6000);
                Assert.AreEqual(expectedId, developer.Id);
                Assert.AreEqual(expectedName, developer.Name);
                Assert.AreEqual(expectedBasicSalary, developer.BasicSalary);
            }
            [TestMethod]
            public void Create_DeveloperDetailToCheckCostOfCompanyOfResult()
            {
                double expectedCTC = 18000;
                double expectedPerformanceAllowance = 500;
                Developer developer = new Developer(101, "rohan", 1000);
                double actualCTC = developer.CostToCompany;
                Assert.AreEqual(expectedCTC, actualCTC);
                Assert.AreEqual(expectedPerformanceAllowance, developer.PerforamceAllowance);
            }
            [TestMethod]
            public void Create_DeveloperSalaryBreakUpAndRole()
            {
                string expectedSalaryBreakup = "Performance Allowance: " + 500;
                string expectedRole = "Developer";
                Developer developer = new Developer(101, "rohan", 1000);
                Assert.AreEqual(expectedSalaryBreakup, developer.SalaryBreakUp);
                Assert.AreEqual(expectedRole, developer.Role);
            }
        }
    }
}

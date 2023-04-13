using AccountsUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountsUnitTestApp
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldCudeAnEvenNumber_2_AndResult_8()
        {
            int expectResult = 8;
            Calculate calculate = new Calculate();
            int actualResult = calculate.CubeOnlyEvenNumber(2);
            Assert.IsTrue(actualResult == expectResult);

        }
        [TestMethod]
        public void CudeingOddNumbergivesResultNegativeValue()
        {
            int expectResult = -1;
            Calculate calculate = new Calculate();
            int actualResult = calculate.CubeOnlyEvenNumber(3);
            Assert.IsTrue(actualResult == expectResult);

        }
        [TestMethod]
        public void Add_ShouldTakeNegativeValuesAndProduceResultCorrectly()
        {
            int expectResult = 200;
            Calculate calculate = new Calculate();
            int actualResult = calculate.Add(-10, 10);
            Assert.IsTrue(expectResult == actualResult);
        }
        [TestMethod]
        public void Add_ShouldTakeInfineValuesAndProduceResult()
        {
            int expectResult = 200;
            Calculate calculate = new Calculate();
            int actualResult = calculate.Add(10, 20, 30, 40);
            Assert.IsTrue(expectResult == actualResult);
        }
        [TestMethod]
        public void Add_ShouldTakeSingleParameter_AndReturnSameValueBack()
        {
            int expectResult = 200;
            Calculate calculate = new Calculate();
            int actualResult = calculate.Add(10);
            Assert.IsTrue(expectResult == actualResult);
        }
        

    }
}
using HumanLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HumanTestApp
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void Create_HumanHavingAllInformayionCheck()
        {
            string expectedName = "vishal";
            int expectedAge = 25;
            string expectedGender = "male";
            float expectedHeight = 180;
            float expectedWeight = 75;
            Human human = new Human("vishal", 22, 34, 5.3f,"Male");
            Assert.AreEqual(expectedAge, human.Age);
            Assert.AreEqual(expectedName, human.Name);
            Assert.AreEqual(expectedGender, human.Gender);
            Assert.AreEqual(expectedWeight, human.Weight);
            Assert.AreEqual(expectedHeight, human.Height);
        }
        [TestMethod]
        public void Create_HumanHavingWorkout()
        {
            float expectedWeight = 76;
            Human human = new Human("vishal", 22, 34, 5.3f,"Male");
            human.Workout();
            Assert.AreEqual(expectedWeight, human.Weight);
        }
        [TestMethod]
        public void Create_CheckGenderAvailableOrNot()
        {
            float expectedWeight = 76;
            Human human = new Human("vishal", 22, 34, 5.3f, "Male");
            human.Workout();
            string expectedGender = "Female";
            Assert.AreEqual(expectedGender, human.Gender);
            
        }
        [TestMethod]
        public void Create_HumanHavingEat()
        {
            float expectedWeight = 88;
            float expectedheight = 183.6f;
            Human human = new Human("vishal", 22, 34, 5.3f,"Male");
            human.Eat();
            Assert.AreEqual(expectedWeight, human.Weight);
            Assert.AreEqual(expectedheight, human.Height);
        }
        [TestMethod]
        public void Create_HumanHavingCalculateBMT()
        {
            float expectedBMT = 25;
            Human human = new Human("vishal", 22, 34, 5.3f,"Male");
            human.Workout();
           Assert.AreEqual(expectedBMT, human.BMI);

        }
    }
}

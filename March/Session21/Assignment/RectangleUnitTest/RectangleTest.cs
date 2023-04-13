using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleEnumApp.Model;
using RectanglEnumApp.Model;
using System;

namespace RectangleUnitTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestBorderProperty()
        {

            int weigth = 30;
            int heigth = 40;
            ColorOption colorOption = ColorOption.GREEN;
            BorderOption borderOption = BorderOption.DOTTED;
;            Rectangle rectangle1 = new Rectangle(weigth, heigth, colorOption);

            Assert.AreEqual(borderOption, rectangle1.Border);
           
           
        }
        [TestMethod]
        public void TestColorProperty()
        {
            int weight = 30;
            int height = 40;
            ColorOption color = ColorOption.BLUE;
            Rectangle rectangle = new Rectangle(weight, height, color);

            ColorOption newColor = ColorOption.RED;
            rectangle.Color = newColor;

            Assert.AreEqual(newColor, rectangle.Color);
            Assert.AreEqual(BorderOption.DOTTED, rectangle.Border);
            
        }
        [TestMethod]
        public  void TestHeightProperty()
        {
            int weight = 30;
            int height = 40;
            ColorOption colorOption = ColorOption.GREEN;
            Rectangle rectangle = new Rectangle(weight, height, colorOption);

            int newHeight = 50;

            Assert.AreEqual(newHeight, rectangle.Height);
        }
    }
}

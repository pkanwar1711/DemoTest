using DemotTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest
{
    [TestClass]
    public class CalUnitTests
    {
        [TestMethod]
        public void AddCal_ShouldAddTwoNumbers()
        {
            //Arrange
            int a = 2;
            int b = 5;

            //Act
            var result = Cal.AddCal(a, b);

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void MulCal_ShouldAddTwoNumbers()
        {
            //Arrange
            int a = 2;
            int b = 5;

            //Act
            var result = Cal.MultiCal(a, b);

            //Assert
            Assert.AreEqual(10, result);
        }
    }
}

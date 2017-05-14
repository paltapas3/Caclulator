using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caclulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caclulator.Tests
{
    // Followng Test cases are for calculator class
    [TestClass()]
    public class CalculatorTests
    {
        Calculator objCalculator = new Calculator();
        [TestMethod()]
        [Owner("Tapas")]
        [TestCategory("Stubbed")]
        [Priority(9)]
        public void AddTestwithInt()
        {
            Assert.IsTrue(objCalculator.Add(10, 20) == 30);
            
        }

        [TestMethod()]
        [Owner("Tapas")]
        [TestCategory("Stubbed")]
        [Priority(9)]
        public void AddTestwithdouble()
        {
           
            Assert.IsTrue(objCalculator.Add(10.50, 20.50) == 31);
        }

        [TestMethod()]
        [Owner("Tapas")]
        [TestCategory("Stubbed")]
        [Priority(9)]
        public void SquareTest()
        {
           
           Assert.IsTrue(objCalculator.Square(8) == 64);
        }

        [TestMethod()]
        [Owner("Tapas")]
        [TestCategory("Stubbed")]
        [Priority(9)]
        public void MultiplyTest()
        {
            Assert.IsTrue(objCalculator.Multiply(8, 9) == 72);
        }

        [TestMethod()]
        [Owner("Tapas")]
        [TestCategory("Stubbed")]
        [Priority(9)]
        public void SubtractTest()
        {
            Assert.IsTrue(objCalculator.Subtract(8, 2) == 6);
        }
    }
}
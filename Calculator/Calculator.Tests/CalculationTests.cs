using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void Calculate_Addition_WorksCorrectly()
        {
            Calculator calculator = new Calculator();
            string result = calculator.Calculate(4, 7, "+");
            Assert.AreEqual("The result of 4 + 7 is 11", result);
        }

        [TestMethod]
        public void Calculate_Subtraction_WorksCorrectly()
        {
            Calculator calculator = new Calculator();
            string result = calculator.Calculate(9, 12, "-");
            Assert.AreEqual("The result of 9 - 12 is -3", result);
        }

        [TestMethod]
        public void Calculate_Multiplication_WorksCorrectly()
        {
            Calculator calculator = new Calculator();
            string result = calculator.Calculate(6, 6, "*");
            Assert.AreEqual("The result of 6 * 6 is 36", result);
        }

        [TestMethod]
        public void Calculate_Division_WorksCorrectly()
        {
            Calculator calculator = new Calculator();
            string result = calculator.Calculate(10, 2, "/");
            Assert.AreEqual("The result of 10 / 2 is 5", result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculate_Division_ThrowsException()
        {
            Calculator calculator = new Calculator();
            string result = calculator.Calculate(10, 0, "/");
        }
    }
}

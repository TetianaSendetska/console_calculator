using System.Linq.Expressions;

namespace Calculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void Calculate_Addition_WorksCorrectly()
        {
            string expression = "2 + 3";
            string result = Expression.Calculate(expression);
            Assert.AreEqual("2 + 3 = 5", result);
        }

        [TestMethod]
        public void Calculate_Multiplication_WorksCorrectly()
        {
            string expression = "4 * 5";
            string result = Expression.Calculate(expression);
            Assert.AreEqual("4 * 5 = 20", result);
        }

        [TestMethod]
        public void Calculate_Sqrt_WorksCorrectly()
        {
            string expression = "sqrt(9)";
            string result = Expression.Calculate(expression);
            Assert.AreEqual("sqrt(9) = 3", result);
        }

        [TestMethod]
        public void Calculate_Abs_WorksCorrectly()
        {
            string expression = "abs(-7)";
            string result = Expression.Calculate(expression);
            Assert.AreEqual("abs(-7) = 7", result);
        }

        [TestMethod]
        public void Calculate_Parentheses_WorksCorrectly()
        {
            string expression = "4 * (5 - 2)";
            string result = Expression.Calculate(expression);
            Assert.AreEqual("4 * (5 - 2) = 12", result);
        }


    }
}
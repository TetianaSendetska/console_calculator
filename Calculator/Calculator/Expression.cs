using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;
using AngouriMath.Extensions;


namespace Calculator
{
    public static class Expression
    {
        public static string Calculate(string expression)
        {
            var expr = MathS.FromString(expression);
            var result = expr.EvalNumerical();

            if (result.ToString() is "Infinity" or "NaN")
                throw new DivideByZeroException("Division by zero detected!");

            return expr.ToString() + " = " + result.ToString();
        }

        private static string NormalizeExpression(string expression)
        {
            expression = expression.Trim();

            if (System.Text.RegularExpressions.Regex.IsMatch(expression, @"^\d+\s+\d+$"))
            {
                throw new Exception("Expression is invalid");
            }

            return expression;
        }
    }
}

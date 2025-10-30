using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;
using AngouriMath.Extensions;


namespace Calculator
{
    internal static class Expression
    {
        public static string Calculate(string expression)
        {
            try
            {
                Entity expr = expression;
                return expression + " = " + expr.EvalNumerical().ToString();

            }
            catch (AngouriMath.Core.Exceptions.UnhandledParseException)
            {
                return "Your expression is invalid";
            }
            catch (Exception ex) {
                return $"Error parsing expression: {ex.Message}";
            }

        }
    }
}

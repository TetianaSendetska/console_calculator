using AngouriMath;
using System.Linq.Expressions;

namespace Calculator
{
    internal static class InputValidation
    {
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                    return number;

                Console.WriteLine("Invalid number! Please try again.");
            }
        }

        public static string ReadOperation()
        {
            while (true)
            {
                Console.Write("Enter an operation (+, -, *, /): ");
                string? op = Console.ReadLine();
                if (op is "+" or "-" or "*" or "/")
                    return op;

                Console.WriteLine("Invalid operation! Please try again.");
            }
        }

        public static string ReadExpression()
        {
            while (true)
            {
                Console.Write("Enter an expression: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Expression cannot be empty. Try again.");
                    continue;
                }
                input = input.Trim();

                if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+(\s+\d+)+$"))
                {
                    Console.WriteLine("Invalid expression! Please try again.");
                    continue;
                }

                try
                {
                    var expr = MathS.FromString(input);
                    return input;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid expression! Please try again.");
                }

            }
        }
    }
}

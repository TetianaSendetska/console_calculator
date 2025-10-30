using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Validation
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
    }
}

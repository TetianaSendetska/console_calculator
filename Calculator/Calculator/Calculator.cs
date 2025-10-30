using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        private readonly IOperation[] _operations;

        public Calculator()
        {
            _operations = new IOperation[]
            {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };
        }

        public string Calculate(double a, double b, string symbol)
        {
            foreach (var op in _operations)
            {
                if (op.Symbol == symbol)
                    return "The result of " + a + " " + symbol + " " + b + " is " + op.Execute(a, b);
            }
            throw new InvalidOperationException($"Symbol '{symbol}' is not supported.");
        }

        public void ShowSupportedOperations()
        {
            Console.WriteLine("All operations:");
            foreach (var op in _operations)
                Console.WriteLine($"  {op.Symbol}");
        }
    }
}

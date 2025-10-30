using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Modes
{
    internal class AdvancedMode : IMode
    {
        public string Name => "Advanced Mode";
        public void Start()
        {
            Console.WriteLine("Enter an expression: ");
            string? expression = Console.ReadLine();
            Console.WriteLine(Expression.Calculate(expression ?? "Undefined expression"));
        }
    }
}

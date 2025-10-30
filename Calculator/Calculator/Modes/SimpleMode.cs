using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Modes
{
    internal class SimpleMode : IMode
    {
        public string Name => "Simple Mode";
        public void Start()
        {
            
                int firstNumber = Validation.ReadInt("Enter first number: ");
                int secondNumber = Validation.ReadInt("Enter second number: ");
                string operation = Validation.ReadOperation();

                Calculator calculator = new();

                Console.WriteLine(calculator.Calculate(firstNumber, secondNumber, operation));
            
        }

    }
}

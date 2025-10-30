using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Division : IOperation
    {
        public string Symbol => "/";
        public double Execute(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("You cannot divide by 0.");
            return a / b;
        }
    }
}

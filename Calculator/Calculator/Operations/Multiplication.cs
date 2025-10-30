using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Multiplication : IOperation
    {
        public string Symbol => "*";
        public double Execute(double a, double b) => a * b;
    }
}

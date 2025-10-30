using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    interface IOperation
    {
        double Execute(double a, double b);
        string Symbol { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Modes
{
    interface IMode
    {
        string Name { get; }
        void Start();
    }
}

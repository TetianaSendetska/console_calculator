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
            try
            {
                string expression = InputValidation.ReadExpression();
                Console.WriteLine(Expression.Calculate(expression));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

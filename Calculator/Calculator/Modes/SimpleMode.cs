namespace Calculator.Modes
{
    internal class SimpleMode : IMode
    {
        public string Name => "Simple Mode";
        public void Start()
        {

            int firstNumber = InputValidation.ReadInt("Enter first number: ");
            int secondNumber = InputValidation.ReadInt("Enter second number: ");
            string operation = InputValidation.ReadOperation();

            Calculator calculator = new();
            try
            {
                Console.WriteLine(calculator.Calculate(firstNumber, secondNumber, operation));

            }
            catch (DivideByZeroException message)
            {
                Console.WriteLine(message.Message);
            }

        }

    }
}

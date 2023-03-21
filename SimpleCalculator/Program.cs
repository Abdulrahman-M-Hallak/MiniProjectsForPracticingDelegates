namespace SimpleCalculator
{
    namespace SimpleCalculator
    {
        public delegate double CalculateOperation(double firstNubmer, double secondNubmer);
        internal class Program
        {
            static void Main(string[] args)
            {
                Dictionary<string, CalculateOperation> Operations = new Dictionary<string, CalculateOperation>()
            {
                {"+", (double firstNumber , double secondNumber) => firstNumber + secondNumber },
                {"-", (double firtsNumber, double secondNumber) => firtsNumber > secondNumber ? firtsNumber - secondNumber : secondNumber - firtsNumber},
                {"*", (double firtsNumber, double secondNumber) => firtsNumber * secondNumber},
                {"/", (double firtsNumber, double secondNumber) => firtsNumber / secondNumber},
            };
                Console.WriteLine("Enter the first number");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The operation");
                string operationSymbol = Console.ReadLine();
                if (Operations.TryGetValue(operationSymbol, out CalculateOperation operation))
                {
                    double result = operation(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }

            }
        }
    }
}
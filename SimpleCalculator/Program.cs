namespace SimpleCalculator
{
    namespace SimpleCalculator
    {
        public delegate double CalculateOperation(double firstNubmer, double secondNubmer);
        internal class Program
        {
            public static double Add(double firtsNumber, double secondNumber) => firtsNumber + secondNumber;
            public static double Substract(double firtsNumber, double secondNumber) => firtsNumber > secondNumber ? firtsNumber - secondNumber : secondNumber - firtsNumber;
            public static double Multiply(double firtsNumber, double secondNumber) => firtsNumber * secondNumber;
            public static double Divide(double firtsNumber, double secondNumber) => firtsNumber / secondNumber;
            static void Main(string[] args)
            {
                Dictionary<string, CalculateOperation> Operations = new Dictionary<string, CalculateOperation>()
            {
                {"+", Add},
                {"-", Substract},
                {"*", Multiply},
                {"/", Divide},
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
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new AddCalculatorOperation());
            double result1 = calculator.Solve(1, 1);
            Console.WriteLine(result1);

            Calculator calculator2 = new Calculator(new SubstractCalculatorOperation());
            double result2 = calculator2.Solve(1, 1);
            Console.WriteLine(result2);


            Calculator calculator3 = new Calculator(new DivideCalculatorOperation());
            double result3 = calculator3.Solve(10, 5);
            Console.WriteLine(result3);

            Calculator calculator4 = new Calculator(new MultiplyCalculatorOperation());
            double result4 = calculator4.Solve(1, 2);
            Console.WriteLine(result4);

        }

    }
}

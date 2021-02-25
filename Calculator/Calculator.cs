using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public ICalculatorOperation CalculatorOperation { get; }
        public Calculator(ICalculatorOperation calculatorOperation)
        {
            CalculatorOperation = calculatorOperation;
        }

        public double Solve(double x,double y)
        {
            return CalculatorOperation.Calculate(x, y);
        }
    }
}

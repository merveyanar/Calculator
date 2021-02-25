using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class MultiplyCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}

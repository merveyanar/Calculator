using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DivideCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x / y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class AddCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}

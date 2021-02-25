using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculatorOperation
    {
        double Calculate(double x, double y);
    }
}

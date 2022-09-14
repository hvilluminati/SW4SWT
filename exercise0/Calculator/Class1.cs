using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise0
{
    public class Calculator
    {
        public Calculator()
        { }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exponent)
        {
            return Math.Pow(x, exponent);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }
    }
}

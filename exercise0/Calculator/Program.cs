using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise0
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
        Calculator TestCalc;
        TestCalc = new Calculator();
        System.Console.WriteLine("Expected result is 4:\n Actual result is: {0}", TestCalc.Add(2.0, 2.0));
        System.Console.WriteLine("Expected result is -4:\n Actual result is: {0}", TestCalc.Add(-2.0, -2.0));

        System.Console.WriteLine("\nExpected result is 3:\n Actual result is: {0}", TestCalc.Subtract(6.0, 3.0));
        System.Console.WriteLine("\nExpected result is -9:\n Actual result is: {0}", TestCalc.Subtract(-6.0, 3.0));

        System.Console.WriteLine("\nExpected result is 16:\n Actual result is: {0}", TestCalc.Multiply(8.0, 2.0));
        System.Console.WriteLine("\nExpected result is -16:\n Actual result is: {0}", TestCalc.Multiply(-8.0, 2.0));
        System.Console.WriteLine("\nExpected result is 0:\n Actual result is: {0}", TestCalc.Multiply(-8.0, 0.0));

        System.Console.WriteLine("\nExpected result is 8:\n Actual result is: {0}", TestCalc.Power(2.0, 3.0));
        System.Console.WriteLine("\nExpected result is -8:\n Actual result is: {0}", TestCalc.Power(-2.0, 3.0));
        System.Console.WriteLine("\nExpected result is 0.125:\n Actual result is: {0}", TestCalc.Power(2.0, -3.0));
        System.Console.WriteLine("\nExpected result is 1:\n Actual result is: {0}", TestCalc.Power(2.0, 0.0));
        }

    }
}

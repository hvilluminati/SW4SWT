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
        System.Console.WriteLine("\nExpected result is 3:\n Actual result is: {0}", TestCalc.Subtract(6.0, 3.0));

        }

    }
}

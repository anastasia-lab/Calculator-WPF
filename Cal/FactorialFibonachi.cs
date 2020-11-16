using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    static class FactorialFibonachi
    {
        public static double Factorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                var factorial = number * Factorial(number-1);
                return factorial;
            }
        }

        public static double Fibonachi(double number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                var fibonachi = Fibonachi(number - 1) + Fibonachi(number - 2);
                return fibonachi;
            }
        }
    }
}

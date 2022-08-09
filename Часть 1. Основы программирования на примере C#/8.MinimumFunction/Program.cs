using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MinimumFunction
{
    class Program
    {

        /*Реализуйте метод GetMinX для нахождения такого числа xxx, при котором кривая, 
         * заданная уравнением y(x)=ax2+bx+cy(x) = ax^2 + bx + cy(x)=ax2+bx+c, принимает минимальное значение.
         * Метод должен принимать неотрицательный коэффициент aaa, а также произвольные коэффициенты bbb и ccc, и, 
         * если решение существует, возвращать строковое представление искомого xxx, а иначе — строку Impossible.*/
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        private static string GetMinX(int a, int b, int c)
        {
            return (a > 0 || (a == 0 && b == 0)) ? (-b / (2.0 * a)).ToString() : "Impossible";
        }
    }
}

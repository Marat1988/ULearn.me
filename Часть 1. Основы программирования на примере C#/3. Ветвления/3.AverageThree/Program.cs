using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.AverageThree
{
    class Program
    {

        public static int MiddleOf(int a, int b, int c)
        {
            return ((a > b && a < c) || (a > c && a < b)) ? 
                a : ((b > a && b < c) || (b > c && b < a)) ? 
                b : (c > a && c < b) || (c > b && c < a) ? 
                c : (a == b || a == c) ? 
                a : (b == a || b == c) ? 
                b : c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
        }
    }
}

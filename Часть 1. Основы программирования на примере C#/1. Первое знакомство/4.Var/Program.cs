using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Var
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 45;
            double angle = 1.4;
            int c = (a + b) / 2;
            Console.WriteLine(Math.Sin(angle));
            var d = a - b;
            /*Часто понятно, какого типа должна быть переменная. В этом случае можно писать var.
             Компилятор самостоятельно догадатеся, что именно вы имели ввиду*/
            var e = a / 2;
            var f = a / 2.0;
            c = a = b;
            a -= 4;
            a++;
            a--;
            ++a;
            a = 5;
            Console.WriteLine(a++);
            //Выведет 5
            a = 5;
            Console.WriteLine(++a);
            //выведет 6
            Console.ReadKey();

        }
    }
}

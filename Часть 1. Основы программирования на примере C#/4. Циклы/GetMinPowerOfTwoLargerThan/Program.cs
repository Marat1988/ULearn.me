using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMinPowerOfTwoLargerThan
{
    class Program
    {
        /*Найдите минимальную степень двойки, превосходящую заданное число.
         * Более формально: для заданного числа nnn найдите минимальное целое x>nx > nx>n, такое, что x=2kx = 2^kx=2k для некоторого целого, неотрицательного kkk.
         * Решите эту задачу с помощью цикла while.*/
        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            int degree = 0;
            while (result <= number)
                result = (int)(Math.Pow(2, degree++));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
        }
    }
}

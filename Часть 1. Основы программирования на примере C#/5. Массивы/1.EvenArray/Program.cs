using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EvenArray
{
    class Program
    {
        /*Напишите метод, который создает массив длинной count элементов, содержащий последовательные четные числа в порядке возрастания.
         * Например, GetFirstEvenNumbers(3) должен вернуть массив 2, 4, 6*/
        public static int[] GetFirstEvenNumbers(int count)
        {
            int number = 2;
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = number;
                number += 2;
            }
            return arr;
        }
        static void Main(string[] args)
        {
        }
    }
}

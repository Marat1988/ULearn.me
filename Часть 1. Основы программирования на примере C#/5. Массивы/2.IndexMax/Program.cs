using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IndexMax
{
    class Program
    {
        /*Чтобы освоиться с массивами, вы с Васей решили потренироваться на простых алгоритмах. Вася написал метод поиска минимума в массиве:
         * static double Min(double[] array)
           {
                var min = double.MaxValue;
                foreach (var item in array)
                    if (item < min) min = item;
                return min;
           }
           А вам выпала задача посложнее — написать метод поиска индекса максимального элемента. 
           То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
           Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
           Если массив пуст, вывести нужно -1.*/
        public static int MaxIndex(double[] array)
        {
            if (array.Count() == 0)
                return -1;
            double maxNumber = array.Max();
            return Array.FindIndex(array, number => number == maxNumber);
        }

        static void Main(string[] args)
        {
        }
    }
}

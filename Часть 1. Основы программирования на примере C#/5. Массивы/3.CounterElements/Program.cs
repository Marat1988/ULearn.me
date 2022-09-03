using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CounterElements
{
    class Program
    {
        /*Тренировки продолжаются. На этот раз вы с Васей наперегонки решаете одну задачу — найти количество вхождений заданного числа в массив чисел.
         * Например, в массиве 1, 2, 1, 1 число 1 встречается 3 раза.*/
        public static int GetElementCount(int[] items, int itemToCount) => items.Where(number => number == itemToCount).Count();
        static void Main(string[] args)
        {
        }
    }
}

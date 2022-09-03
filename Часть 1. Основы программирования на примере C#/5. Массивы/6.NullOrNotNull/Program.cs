using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.NullOrNotNull
{
    class Program
    {

        /*Вася написал метод, проверяющий, что первый элемент переданного массива равен 0. 
         * Вася даже проверил, что ему не передали в качестве массива null. Но что-то все равно не работает.
         * Исправьте ошибку и разберитесь, почему код не работал.*/

        public static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }
        static void Main(string[] args)
        {
        }
    }
}

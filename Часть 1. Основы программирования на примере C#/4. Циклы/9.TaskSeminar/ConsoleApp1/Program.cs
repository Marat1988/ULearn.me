using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        /*Loops1. Дано целое неотрицательное число N. 
         * Найти число, составленное теми же десятичными цифрами, что и N, но в обратном порядке. Запрещено использовать массивы.*/
        static long Reverse(int a)
        {
            return (long.TryParse(string.Join("", a.ToString().Reverse().ToArray()), out long number)) ? number : 0;
        }

        /*Loops2. Дано N (1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, сумма цифр которых равна N. 
         * Операции деления (/, %) не использовать */
        static int NumberSum(int number)
        {
            int count = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i.ToString().ToCharArray().Sum(c => c - 0x30) == number)
                    count++;
            }
            return count;
        }

        /*Loops3. Если все числа натурального ряда записать подряд каждую цифру в своей позиции, 
         * то необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.*/
        static void SearchNumber(int number, int index = 0) => Console.WriteLine(number.ToString()[index]);

        /* Loops4. В массиве чисел найдите самый длинный подмассив из одинаковых чисел.*/
        static int[] GetSubArray(int[] array)
        {
            int countNum = 1;
            List<int> lst = new List<int>();
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                    countNum++;
                else
                {
                    if (lst.Count < countNum)
                    {
                        lst.Clear();
                        for (int j = i - 1; countNum > 0; j--)
                        {
                            lst.Add(array[j]);
                            countNum--;
                        }
                    }
                    countNum = 1;
                }
            }
            int[] arr2 = new int[lst.Count];
            for (int i = 0; i < lst.Count; i++)
            {
                arr2[i] = lst[i];
            }
            return arr2;
        }

        /* Loops5. Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением. 
         * Определить максимальную глубину вложенности скобок.*/
        /* Примечание : для некорректных - будем возвращать глубину "0" */
        static int GetDepthBrackets(string stringBrackets)
        {
            // current count
            int current_max = 0;
            // overall maximum count
            int max = 0;
            int n = stringBrackets.Length;
            // Traverse the input string
            for (int i = 0; i < n; i++)
            {
                if (stringBrackets[i] == '(')
                {
                    current_max++;
                    // update max if required
                    if (current_max > max)
                        max = current_max;
                }
                else if (stringBrackets[i] == ')')
                {
                    if (current_max > 0)
                        current_max--;
                    else
                        return 0;
                }
            }
            // finally check for unbalanced string
            if (current_max != 0)
                return 0;
            return max;
        }
        static void Main(string[] args)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BuildingInDegree
{
    class Program
    {
        /*Помогите Васе написать метод, который принимает массив int[], возводит все его элементы в
         * заданную степень и возвращает массив с результатом этой операции.
         * Исходный массив при этом должен остаться неизменным.*/
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            return arr.Select(x => (int)Math.Pow(x, power)).ToArray();
        }
        static void Main(string[] args)
        {
        }
    }
}

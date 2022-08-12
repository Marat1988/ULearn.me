using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IsLeapYear
{
    class Program
    {
        /*Функция, определяющая высокосный год*/
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 == 0 && year % 400 == 0) ? true : (year % 4 == 0 && year % 100 > 0) ? true : false;
        }
        static void Main(string[] args)
        {
        }
    }
}

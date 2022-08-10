using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Decode
{
    class Program
    {
        /*Задача-загадка. Задания нет — так и задумано. Не бойтесь экспериментировать. 
         * Запустите код на выполнение и внимательно изучите ошибки. 
         * Ориентируясь на текст ошибок попробуйте сами понять, что нужно сделать.
         * Эта задача требует смекалки и упорства!*/
        static string Decode(string str)
        {
            str = str.Replace(".", "");
            int number = int.Parse(str);
            string numberToBit = Convert.ToString(number, 2);
            if (numberToBit.Length > 10)
            {
                numberToBit = numberToBit.Substring(numberToBit.Length - 10, 10);
                return Convert.ToInt32(numberToBit, 2).ToString();
            }
            else
                return Convert.ToInt32(numberToBit, 2).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Decode("1010"));
            Console.ReadKey();
        }
    }
}

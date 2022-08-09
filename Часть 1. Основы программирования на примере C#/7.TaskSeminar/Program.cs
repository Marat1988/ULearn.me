using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.TaskSeminar
{
    class Program
    {
        /*Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?*/
        static void task1()
        {
            int a = 5;
            int b = 6;
            Console.WriteLine($"Начальное значение переменной A равно {a}");
            Console.WriteLine($"Начальное значение переменной B равно {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Конечное значение переменной A равно {a}");
            Console.WriteLine($"Начальное значение переменной B равно {b}");
        }
        /*Expr2.Задается натуральное трехзначное число(гарантируется, что трехзначное). Развернуть его, 
        т.е.получить трехзначное число, записанное теми же цифрами в обратном порядке.*/
        static void task2()
        {
            Console.Write("Введите число ");
            if (int.TryParse(Console.ReadLine(),out int number))
                Console.WriteLine(number.ToString().Reverse().ToArray());
            else
                Console.WriteLine("Не корректный ввод номера числа");
        }
        /*Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. 
         * Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.*/
        static void task3(int hour)
        {
            Console.WriteLine($"{hour} часов -> " + (hour > 6 ? (360 - ((hour - 12) * 30)) : (hour * 30)) + " градусов");
        }
        /*Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.*/
        static void task4(int countNumber = 20, int x = 3, int y = 5)
        {
            /*Работает при условии, что x и у являются простыми числами*/
            countNumber--;
            Console.WriteLine(countNumber / x + countNumber / y - (countNumber / (x * y)));
        }
        /*Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.*/
        static void task5(int beginYear = 1900, int endYear = 2022)
        {
            Console.WriteLine(Enumerable.Range(beginYear, (endYear - beginYear + 1)).Where(i => DateTime.IsLeapYear(i) == true).Count());
        }
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=====================================================");
            task2();
            Console.WriteLine("=====================================================");
            task3(20);
            Console.WriteLine("=====================================================");
            task4();
            Console.WriteLine("=====================================================");
            task5();
        }
    }
}

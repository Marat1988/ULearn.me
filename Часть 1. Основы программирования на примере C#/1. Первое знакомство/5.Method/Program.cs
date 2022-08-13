using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Method
{
    class Program
    {
        private static void Print(int number)
        {
            Console.WriteLine(number);
        }
        private static int GetSquare(int num)
        {
            return (int)Math.Pow(num, 2);
        }

        private static string GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name}, your salary is {Math.Ceiling(salary)}";
        }
        static int DivideAndRound(double a, double b)
        {
            return (int)Math.Round(a / b);
        }
        static void WriteNumber(int number)
        {
            Console.WriteLine(number);
        }
        static void WriteNumber(int number, int anotherNumber)
        {
            Console.WriteLine(number);
            Console.WriteLine(anotherNumber);
        }

        static string GetLastHalf(string str)
        {
            return str.Substring(str.Length / 2).Replace(" ", "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)Math.Round(6.5));
            WriteNumber(DivideAndRound(10.5, 2.1));
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
            Print(GetSquare(42));

            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
            Console.ReadKey();
        }
    }
}

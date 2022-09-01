using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WriteTextWithBorder
{
    class Program
    {
        /*Вы решили помочь Васе с разработкой его игры и взяли на себя красивый вывод сообщений в игре.
         * Напишите функцию, которая принимает на вход строку текста и печатает ее на экран в рамочке из символов +, - и |. 
         * Для красоты текст должен отделяться от рамки слева и справа пробелом.
         * Например, текст Hello world должен выводиться так:
         * +-------------+
         * | Hello world |
         * +-------------+*/
        private static void WriteTextWithBorder(string text)
        {
            var bar = "+" + new string('-', text.Length + 2) + "+";
            Console.WriteLine(bar);
            Console.WriteLine("| {0} |", text);
            Console.WriteLine(bar);
        }
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }
    }
}

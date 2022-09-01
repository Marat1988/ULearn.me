using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.WriteBoard
{
    class Program
    {
        /*Стали известны подробности про новую игру Васи. Оказывается ее действия разворачиваются на шахматных досках нестандартного размера.
         * У Васи уже написан код, генерирующий стандартную шахматную доску размера 8х8.
         * Помогите Васе переделать этот код так, чтобы он умел выводить доску любого заданного размера.
         * Например, доска размера пять должна выводиться так:
        #.#.#  
        .#.#.  
        #.#.#  
        .#.#.  
        #.#.#  */
        private static void WriteBoard(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row % 2 == 0)
                        Console.Write(col % 2 == 0 ? "#" : ".");
                    else
                        Console.Write(col % 2 == 0 ? "." : "#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }
    }
}

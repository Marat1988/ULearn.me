using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Variables
{
    class Program
    {
        static string globalVariable = "Global variable";
        static void MethodA()
        {
            if (globalVariable == "")
            {
                string temporalVariable = "Temporal variable";
                Console.WriteLine(temporalVariable);
            }
            string localVariable = "Local variable";
            //Так можно - эта переменная используется в той же области, где и объявлена
            Console.WriteLine(localVariable);
            //Так нельзя - temporalVariable определена только внутри блока if.
            //Console/WriteLine(temporalVariable);
        }
        static void MethodB()
        {
            //Console.WriteLine(localVariable). //Нельзя. Переменная определена в другом методе
            Console.WriteLine(globalVariable); //Можно - это глобальная переменная
        }
        static void Main(string[] args)
        {
  
        }
    }
}

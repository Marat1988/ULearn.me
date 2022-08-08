using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello, world!";
            string s = "Hello" + " " + "world";
            char c = myString[1];
            char myChar = 'e';
            Console.WriteLine(myString.Length);
            myString = myString.Substring(0, 5);
            Console.WriteLine(myString);
            string strangeSymbols = "© 2014 Σγμβόλσ";
            myString = null;
            int number = int.Parse("42");
            string numString = number.ToString();//Из числа в строку
            double number2 = double.Parse("34.42",CultureInfo.InvariantCulture);
            //Следующий вызов не зависит от настроек и всегода использует точку в качестве размедителя
            string invariantNumber2 = number2.ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(invariantNumber2);
            Console.ReadKey();
        }
    }
}

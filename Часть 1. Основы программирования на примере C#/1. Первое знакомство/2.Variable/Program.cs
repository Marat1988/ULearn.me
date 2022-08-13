using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerNumber = 45; //Объявление переменной тиипа int
            double doubleNumber=34.56; //Объявление переменной типа double
            integerNumber = (int)doubleNumber; //Явноя конверсия типов
            integerNumber = (int)Math.Round(34.67);
            long longInteger = 4000000000;
            integerNumber = (int)longInteger;
            //При такой конверсии происходит ошибка переполнения, которая, однако,
            //остается незамеченной для компилятора и среды разработки

            //Таким образом можно отловить эти ошибки явно
             checked
             {
                 integerNumber = (int)longInteger;
             }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TaskSeminar
{
    class Program
    {
        /*Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.*/
        static void Task1()
        {
            Console.WriteLine(Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i % 5 == 0).Sum());
        }

        /*Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.*/
        static int GetAngle(int hour, int minute)
        {
            int angleHourHand = (30 * hour);
            angleHourHand = angleHourHand + ((int)(minute * 0.5));
            int angleMinuteHand = minute * 6;
            int corner = Math.Abs(angleHourHand - angleMinuteHand);
            return (corner > 180) ? (360 - corner) : corner;
        }
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine("================================================================");
            Console.WriteLine(GetAngle(1,20));
        }
    }
}

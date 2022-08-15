using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TaskSeminar
{
    class Program
    {
        /*Cond3. (1493. В одном шаге от счастья) Дан номер трамвайного билета, в котором суммы первых трёх цифр 
         * и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону). 
         * Правда ли, что предыдущий или следующий билет счастливый?*/
        static  bool LuckyTicket(string numberTicket)
        {
            int sum1 = Array.ConvertAll(numberTicket.ToCharArray(), c => (int)Char.GetNumericValue(c)).Where((number, index) => index < 3).Sum();
            int sum2 = Array.ConvertAll(numberTicket.ToCharArray(), c => (int)Char.GetNumericValue(c)).Where((number, index) => index >= 3).Sum();
            if (sum1 == sum2 + 1 || sum1 == sum2 - 1)
            {
                int sum3 = Array.ConvertAll((int.Parse(numberTicket.Substring(numberTicket.Length - 3)) + 1).ToString().ToCharArray(), c => (int)Char.GetNumericValue(c)).Sum();
                int sum4 = Array.ConvertAll((int.Parse(numberTicket.Substring(numberTicket.Length - 3)) - 1).ToString().ToCharArray(), c => (int)Char.GetNumericValue(c)).Sum();
                return (sum1 == sum3 || sum1 == sum4);
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}

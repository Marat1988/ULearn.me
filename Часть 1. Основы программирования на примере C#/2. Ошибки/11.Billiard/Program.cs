using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Billiard
{
    class Program
    {
        /*Реализуйте метод для расчета угла отскока шарика от стены. Считайте, что угол падения равен углу отражения, 
         * то есть можно пренебречь всеми физическими эффектами, связанными с кручением шаров, трением шара об стенку и т.п.*/
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            return 2 * wallInclinationRadians - directionRadians;
        }

        static void Main(string[] args)
        {
        }
    }
}

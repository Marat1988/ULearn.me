using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Robot
{
    class Program
    {
        /*В воскресенье Вася пошел в кружок робототехники и увидел там такой код управления боевым роботом:
         
         static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
         {
	        bool shouldFire = true;
	        if (enemyInFront == true)
	        {
		        if (enemyName == "boss")
		        {
			        if (robotHealth < 50) shouldFire = false;
			        if (robotHealth > 100) shouldFire = true;
		        }
	        }
	        else
	        {
		        return false;
	        }
	        return shouldFire;
        }
        Код показался Васе слишком длинным, а к тому же еще и неряшливым. Вася поспорил с автором, что сможет написать функцию, 
        делающую ровно то же самое, но всего в один оператор. Кажется, Вася погорячился... Или нет? Помогите ему не проиграть в споре!*/
        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return (enemyInFront && enemyName == "boss") ? robotHealth >= 50 && ((robotHealth > 100) || true) : enemyInFront;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ShouldFire2(true, "Zombie", 10));
        }
    }
}

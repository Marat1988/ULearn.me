using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.PluralizeRubles
{
    class Program
    {
		/*Напишите метод, склоняющий существительное «рублей» следующее за указанным числительным.
		 * Например, для аргумента 10, метод должен вернуть «рублей», для 1 — вернуть «рубль», для 2 — «рубля».
		 * Для проверки своего решения запустите скачанный проект.*/
		public static class PluralizeTask
		{
			public static string PluralizeRubles(int count)
			{
				switch (count % 100)
				{
					case 11:
					case 12:
					case 13:
					case 14:
						return "рублей";
					default:
						switch (count % 10)
						{
							case 1:
								return "рубль";
							case 2:
							case 3:
							case 4:
								return "рубля";
							default:
								return "рублей";
						}
				}
			}
		}

		static void Main(string[] args)
        {
        }
    }
}

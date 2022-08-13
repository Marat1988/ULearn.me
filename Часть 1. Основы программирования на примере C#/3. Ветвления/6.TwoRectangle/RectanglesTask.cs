using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		/*Вам даны два прямоугольника на плоскости, со сторонами параллельными осям координат с целочисленными координатами.
		 * Реализуйте в классе RectanglesTask.cs три метода для работы с прямоугольниками:
		 * определение, есть ли у двух прямоугольников хотя бы одна общая точка (и граница и внутренность считаются частью прямоугольника);
		 * вычисление площади пересечения;
		 * определение, вложен ли один в другой.
		 * Решите задание без использования библиотечных методов, кроме Min и Max.
		 * Обратите внимание, что ваше решение должно корректно работать с вырожденными прямоугольниками: у которых длина или ширина равны 0.
		 * Для проверки своего решения запустите скачанный проект.
		 * В мире компьютерной графики принято, что верхний левый угол экрана имеет координаты (0, 0), а ось Y направлена вниз, а не вверх, как принято в математике. Поэтому в этой задаче нижний край прямоугольника имеет большую координату, чем верхний. Учитывайте это при решении задачи!*/

		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
			return ((r2.Right >= r1.Left && r2.Right <= r1.Right && r2.Top >= r1.Top && r2.Top <= r1.Bottom) ||
					(r1.Right >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Top <= r2.Bottom) ||
					(r2.Left >= r1.Left && r2.Left <= r1.Right && r2.Top >= r1.Top && r2.Top <= r1.Bottom) ||
					(r1.Left >= r2.Left && r1.Left <= r2.Right && r1.Top >= r2.Top && r1.Top <= r2.Bottom) ||
					(r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top >= r1.Top && r2.Top <= r1.Bottom) ||
					(r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top >= r2.Top && r1.Top <= r2.Bottom)) ? true : false;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			if (AreIntersected(r1, r2))
            {
				int x_overlap = Math.Max(0, Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left));
				int y_overlap = Math.Max(0, Math.Min(r1.Bottom, r2.Bottom) - Math.Max(r1.Top, r2.Top));
				return x_overlap * y_overlap;
			}
			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom) return 1;
			if (r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top <= r1.Top && r2.Bottom >= r1.Bottom) return 0;
			return -1;
		}
	}
}
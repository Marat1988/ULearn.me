using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			if (ax == bx && ay == by) return Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
			double sideC = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
			double sideA = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
			double sideB = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));
			if ((sideB * sideB > (sideA * sideA + sideC * sideC)) ||
				(sideA * sideA > (sideB * sideB + sideC * sideC))) 
				return Math.Min(sideA, sideB);	
			double a = by - ay;
			double b = ax - bx;
			double c = -ax * (by - ay) + ay * (bx - ax);
			return (Math.Abs(a * x + b * y + c)) / Math.Sqrt(a * a + b * b);	
		}
	}
}
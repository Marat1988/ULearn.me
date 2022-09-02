using System;

namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int numberMoves = (int)Math.Round((double)Math.Max(width, height) / Math.Min(width, height));
			while (true)
			{
				for (int i = 0; i < numberMoves; i++)
					robot.MoveTo(width > height ? Direction.Right : Direction.Down);
				if (robot.Finished) 
					break; 
				else 
					robot.MoveTo(width > height ? Direction.Down : Direction.Right);              
			}
		}
	}
}

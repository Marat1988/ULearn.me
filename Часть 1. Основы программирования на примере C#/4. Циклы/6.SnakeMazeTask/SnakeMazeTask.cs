namespace Mazes
{
	public static class SnakeMazeTask
	{
		private static void MoveDown(Robot robot)
        {
			for (int i = 0; i < 2; i++)
				robot.MoveTo(Direction.Down);
		}
		public static void MoveOut(Robot robot, int width, int height)
		{
            while (true)
            {			
				for (int i = robot.X; i < width - 2; i++)
					robot.MoveTo(Direction.Right);
				MoveDown(robot);
				for (int i = robot.X; i > 1; i--)
					robot.MoveTo(Direction.Left);
				if (robot.Finished) break;
				MoveDown(robot);
			}
		}
	}
}
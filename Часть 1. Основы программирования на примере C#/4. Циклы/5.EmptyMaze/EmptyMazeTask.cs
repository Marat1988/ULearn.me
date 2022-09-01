namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            for (int i = robot.X; i < width - 2; i++)
				robot.MoveTo(Direction.Right);
			for (int i = robot.Y; i < height - 2; i++)
				robot.MoveTo(Direction.Down);
		}
	}
}
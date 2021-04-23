using System;

public enum Direction { North, East, South, West }

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        Facing = direction;
        X = x;
        Y = y;
    }

    public Direction Facing { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }

    public void Move(string instructions)
    {
        foreach (char instruction in instructions)
            switch (instruction)
            {
                case 'L': TurnLeft(); break;
                case 'R': TurnRight(); break;
                case 'A': Advance(); break;
                default: throw new Exception("Unknown instruction: " + instruction);
            }
    }

    private void Advance()
    {
        switch (Facing)
        {
            case Direction.East: X += 1; break;
            case Direction.South: Y -= 1; break;
            case Direction.West: X -= 1; break;
            case Direction.North: Y += 1; break;
        }
    }

    private void TurnRight() =>
        Facing = Facing switch
        {
            Direction.North => Direction.East,
            Direction.East => Direction.South,
            Direction.South => Direction.West,
            Direction.West => Direction.North,
        };

    private void TurnLeft() =>
        Facing = Facing switch
        {
            Direction.East => Direction.North,
            Direction.North => Direction.West,
            Direction.West => Direction.South,
            Direction.South => Direction.East,
        };
}
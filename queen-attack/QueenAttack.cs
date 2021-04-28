using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Row == black.Row || white.Column == black.Column)
            return true;

        var rowDiff = Math.Abs(white.Row - black.Row);
        var colDiff = Math.Abs(white.Column - black.Column);

        return rowDiff - colDiff == 0;
    }

    public static Queen Create(int row, int column) =>
        row < 0 || row > 7 || column < 0 || column > 7
            ? throw new ArgumentOutOfRangeException()
            : new Queen(row, column);
}
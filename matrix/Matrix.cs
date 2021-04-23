using System.Linq;

public class Matrix
{
    private int[][] _matrix;

    public Matrix(string input)
    {
        _matrix = input.Split('\n')
            .Select(row => row.Split()
                .Select(col => int.Parse(col))
                .ToArray())
            .ToArray();

        Rows = _matrix.Length;
        Cols = _matrix[0].Length;
    }

    public int Rows { get; }

    public int Cols { get; }

    public int[] Row(int row) => _matrix[row - 1];

    public int[] Column(int col) => _matrix.Select(row => row[col - 1]).ToArray();
}
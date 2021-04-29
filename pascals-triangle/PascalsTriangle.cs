using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        var arr = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            arr[i] = new int[i + 1];
            arr[i][0] = 1;
            arr[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
            }
        }

        return arr;
    }
}
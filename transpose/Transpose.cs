using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Transpose
{
    public static string String(string input)
    {
        var rows = input.Split('\n');
        var maxLength = rows.Max(s => s.Length);
        var list = new List<string>();

        for (int column = 0; column < maxLength; column++)
        {
            int spaces = 0;
            var columnsBuilder = new StringBuilder();

            foreach (var row in rows)
            {
                if (column < row.Length)
                {
                    columnsBuilder.Append(' ', spaces);
                    columnsBuilder.Append(row[column]);
                    spaces = 0;
                }
                else spaces++;
            }

            list.Add(columnsBuilder.ToString());
        }

        return string.Join('\n', list);
    }
}
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var bandColor = new List<string> {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

        return int.Parse(string.Concat(colors.Take(2).Select(c => $"{bandColor.IndexOf(c)}")));
    }
}
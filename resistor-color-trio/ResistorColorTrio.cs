using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorTrio
{
    private static readonly List<string> BandColors = new List<string>
        {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static string Label(string[] colors)
    {
        if (colors.Length != 3)
            throw new NotSupportedException("Only supports three colors");

        var first2 = int.Parse(string.Concat(colors.Take(2).Select(c => $"{BandColors.IndexOf(c)}")));
        var multiple = int.Parse($"{BandColors.IndexOf(colors[2])}");
        var ohms = first2 * (multiple == 0 ? 1 : Math.Pow(10, multiple));

        return ohms < 1000 ? $"{ohms} ohms" : $"{ohms / 1000} kiloohms";
    }
}
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var numToString = new Dictionary<int, string>() { { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" }, };

        return string.Concat(numToString.Where(n => number % n.Key == 0)
                                        .Select(n => n.Value)
                                        .DefaultIfEmpty(number.ToString()));
    }
}
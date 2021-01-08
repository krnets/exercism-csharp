using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    static readonly Dictionary<string, int> Scrabble = new Dictionary<string, int>()
    {
        ["AEIOULNRST"] = 1,
        ["DG"] = 2,
        ["BCMP"] = 3,
        ["FHVWY"] = 4,
        ["K"] = 5,
        ["JX"] = 8,
        ["QZ"] = 10
    };

    public static int Score(string input) => input.ToUpper().Sum(c => Scrabble.First(kvp => kvp.Key.Contains(c)).Value);
}
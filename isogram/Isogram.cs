using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word) => word.ToLower()
        .Where(char.IsLetter)
        .GroupBy(c => c)
        .ToDictionary(g => g.Key, g => g.Count()).Values
        .All(i => i == 1);
}
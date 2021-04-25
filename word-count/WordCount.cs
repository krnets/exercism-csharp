using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        var pattern = @"\b[\w']+\b";

        return Regex.Matches(phrase.ToLower(), pattern)
            .GroupBy(m => m.Value)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}
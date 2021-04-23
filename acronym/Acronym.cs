using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var words = Regex.Split(phrase.ToUpper(), @"[-_\s]+");

        return string.Concat(words.Select(w => w[0]).Where(char.IsLetter));
    }
}
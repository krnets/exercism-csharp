using System.Linq;
using System.Text.RegularExpressions;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        if (string.IsNullOrEmpty(number))
            return false;

        number = number.Replace("-", "");
        var checkLength = number.Length == 10;
        var checkLastX = Regex.IsMatch(number.Last().ToString(), @"[X\d]");

        return checkLength && checkLastX &&
               number.Reverse()
                   .Select((c, i) => c == 'X' ? 10 : char.GetNumericValue(c) * (i + 1))
                   .Sum() % 11 == 0;
    }
}
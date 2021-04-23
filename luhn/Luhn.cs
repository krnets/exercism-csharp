using System;
using System.Linq;

public static class Luhn
{
    public static bool IsValid(string number)
    {
        number = number.Replace(" ", "");

        return number.Length > 1 && number.All(char.IsDigit) &&
                 number.Reverse()
                       .Where(char.IsDigit)
                       .Select(char.GetNumericValue)
                       .Select((n, i) => i % 2 == 0 ? n : n * 2)
                       .Select(n => n > 9 ? n - 9 : n)
                       .Sum() % 10 == 0;
    }
}
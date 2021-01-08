using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var pattern = "^1?([2-9]\\d\\d[2-9]\\d{6})$";
        var digitsOnly = string.Concat(phoneNumber.Where(char.IsDigit));
        var matches = Regex.Match(digitsOnly, pattern);

        return matches.Success ? matches.Groups[1].ToString() : throw new ArgumentException();
    }
}
using System.Text.RegularExpressions;

public static class RunLengthEncoding
{
    public static string Encode(string input) =>
        Regex.Replace(input, @"(\D)\1+", m => m.Length.ToString() + m.Value[0]);

    public static string Decode(string input) =>
        Regex.Replace(input, @"(?<digits>\d+)(?<char>\D)",
            m => new string(m.Groups["char"].Value[0], int.Parse(m.Groups["digits"].Value)));
}
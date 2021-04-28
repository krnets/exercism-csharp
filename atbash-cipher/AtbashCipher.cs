using System.Collections.Generic;
using System.Linq;

public static class AtbashCipher
{
    static Dictionary<char, char> cipherMap;

    static AtbashCipher() =>
        cipherMap = Enumerable.Range('a', 26).ToDictionary(c => (char)c, c => (char)('z' - (c - 'a')));

    public static string Encode(string plainValue) =>
        string.Concat(plainValue.ToLower()
            .Where(char.IsLetterOrDigit)
            .Select(c => cipherMap.GetValueOrDefault(c, c))
            .Select((c, i) => i % 5 == 0 && i > 0 ? $" {c}" : $"{c}"));

    public static string Decode(string encodedValue) =>
        string.Concat(encodedValue.Replace(" ", "").Select(c => cipherMap.GetValueOrDefault(c, c)));
}
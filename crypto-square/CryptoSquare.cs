using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class CryptoSquare
{
    private static int _rows;
    private static int _columns;

    public static string NormalizedPlaintext(string plaintext) => Regex.Replace(plaintext, "\\W", "").ToLower();

    public static IEnumerable<string> PlaintextSegments(string plaintext) =>
        Enumerable.Range(0, _rows)
            .Select(i => plaintext[(i * _columns)..].PadRight(_columns, ' '));

    public static string Encoded(string plaintext) =>
        string.Join(" ", Enumerable.Range(0, _columns)
            .Select(column => string.Concat(PlaintextSegments(plaintext).Select(segment => segment[column]))));

    public static string Ciphertext(string plaintext)
    {
        var normalized = NormalizedPlaintext(plaintext);
        var sqRootLength = Math.Sqrt(normalized.Length);
        _rows = (int)(normalized.Length < 10 ? Math.Ceiling(sqRootLength) : sqRootLength);
        _columns = (int)Math.Ceiling(sqRootLength);

        return Encoded(normalized);
    }
}
using System;
using System.Linq;

public class SimpleCipher
{
    public string Key { get; }
    public SimpleCipher() => Key = GenerateRandomKey();
    public SimpleCipher(string key) => Key = key;
    private Random Rng = new Random(DateTime.Today.Millisecond);

    public string Encode(string plaintext) => HelperMethod(plaintext, true);
    public string Decode(string ciphertext) => HelperMethod(ciphertext, false);

    private string HelperMethod(string text, bool shiftRight) =>
        string.Concat(Enumerable.Range(0, text.Length)
            .Select(i =>
            {
                int current = text[i] - 'a';
                int offset = Key[i % Key.Length] - 'a';
                int c = (shiftRight ? (current + offset) : 26 + current - offset) % 26;
                return (char)('a' + c);
            }));

    private string GenerateRandomKey() =>
        string.Concat(Enumerable.Range(0, 100).Select(i => (char)('a' + Rng.Next(26))));
}
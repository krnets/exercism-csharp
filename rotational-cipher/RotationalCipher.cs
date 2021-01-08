using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return string.Concat(text.Select(c => ShiftCharBy(c, shiftKey)));
    }

    private static char ShiftCharBy(char c, int shiftKey)
    {
        if (!char.IsLetter(c))
            return c;

        char firstLetter = char.IsUpper(c) ? 'A' : 'a';

        return (char)((c + shiftKey - firstLetter) % 26 + firstLetter);
    }
}
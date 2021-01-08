using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var sb = new StringBuilder(input.Length);

        foreach (char c in input)
            sb.Insert(0, c);

        return sb.ToString();
    }
}
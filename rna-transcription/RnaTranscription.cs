using System.Collections.Generic;
using System.Text;

public static class RnaTranscription
{
    private static Dictionary<char, char> map = new Dictionary<char, char>()
        { {'C', 'G' }, {'G', 'C'}, {'T', 'A'}, {'A', 'U'} };

    public static string ToRna(string nucleotide)
    {
        var sb = new StringBuilder();

        foreach (var item in nucleotide)
        {
            sb.Append(map[item]);
        }

        return sb.ToString();
    }
}
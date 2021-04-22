using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> map = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var c in sequence)
        {
            if (map.ContainsKey(c)) map[c] += 1;
            else throw new System.ArgumentException();
        }
        return map;
    }
}
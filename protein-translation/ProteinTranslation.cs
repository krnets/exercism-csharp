using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var AminoAcids = new Dictionary<string[], string>
        {
            {new []{"UUU", "UUC"}, "Phenylalanine"},
            {new []{"AUG"}, "Methionine"},
            {new []{"UUU", "UUC"}, "Phenylalanine"},
            {new []{"UUA", "UUG"}, "Leucine"},
            {new []{"UCU", "UCC", "UCA", "UCG"}, "Serine"},
            {new []{"UAU", "UAC"}, "Tyrosine"},
            {new []{"UGU", "UGC"}, "Cysteine"},
            {new []{"UGG"}, "Tryptophan"},
            {new []{"UAA", "UAG", "UGA"}, "STOP"}
        };

        return Enumerable.Range(0, strand.Length / 3)
            .Select(i => strand.Substring(3 * i, 3))
            .Select(s => AminoAcids.First(kvp => kvp.Key.Contains(s)).Value)
            .TakeWhile(s => s != "STOP")
            .ToArray();
    }
}
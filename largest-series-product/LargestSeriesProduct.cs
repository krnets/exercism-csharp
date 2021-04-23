using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || span > digits.Length || digits.Any(c => !char.IsDigit(c)))
            throw new ArgumentException();

        return Enumerable.Range(0, digits.Length - span + 1)
                         .Select(i => digits.Substring(i, span)
                               .Select(c => (int)char.GetNumericValue(c))
                               .Aggregate(1, (a, b) => a * b))
                         .Max();
    }
}
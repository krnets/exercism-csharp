using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0) throw new ArgumentOutOfRangeException();

        var aliquotSum = Enumerable.Range(1, number / 2)
            .Where(i => number % i == 0)
            .Sum();

        return aliquotSum < number ? Classification.Deficient :
            aliquotSum > number ? Classification.Abundant :
            Classification.Perfect;
    }
}

using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        var factors = new List<long>();

        for (long i = 2; number > 1;)
            if (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
            else i++;

        return factors.ToArray();
    }
}
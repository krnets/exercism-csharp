using System;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
            throw new ArgumentOutOfRangeException("No primes under two");

        var sieve = new bool[limit + 1];

        Array.Fill(sieve, true, 2, sieve.Length - 2);

        for (int i = 2; i <= Math.Sqrt(limit); i++)
            for (int j = i * i; j <= limit; j += i)
                sieve[j] = false;

        return Enumerable.Range(1, limit).Where(i => sieve[i]).ToArray();
    }
}
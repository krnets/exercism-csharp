using System;
using System.Linq;

public static class NthPrime
{
    public static int Prime(int nth) =>
        nth < 1
            ? throw new ArgumentOutOfRangeException()
            : Enumerable.Range(2, int.MaxValue - 2)
                .Where(IsPrime)
                .ElementAt(nth - 1);

    private static bool IsPrime(int n)
    {
        if (n <= 3 || n == 5) return true;
        if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0) return false;

        for (int i = 5; i <= Math.Sqrt(n); i += 6)
            if (n % i == 0 || n % (i + 2) == 0)
                return false;

        return true;
    }
}
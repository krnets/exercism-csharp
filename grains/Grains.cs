using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64) throw new ArgumentOutOfRangeException();

        return 1UL << (n - 1);
    }

    public static ulong Total()
    {
        return Enumerable.Range(1, 64)
                         .Select(Square)
                         .Aggregate((acc, val) => acc + val);
    }
}
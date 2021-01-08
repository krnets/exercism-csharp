using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        multiples = multiples.Where(x => x > 0);
            
        return Enumerable
            .Range(0, max)
            .Where(x => multiples.Any(y => x % y == 0))
            .Sum();
    }
}
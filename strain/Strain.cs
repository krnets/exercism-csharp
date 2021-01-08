using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var enumerator = collection.GetEnumerator();

        while (enumerator.MoveNext())
        {
            var item = enumerator.Current;

            if (predicate(item))
                yield return item;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var enumerator = collection.GetEnumerator();

        while (enumerator.MoveNext())
        {
            var item = enumerator.Current;

            if (!predicate(item))
                yield return item;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public enum SublistType
{
    Equal,
    Unequal,
    Superlist,
    Sublist
}

public static class Sublist
{
    public static SublistType Classify<T>(List<T> list1, List<T> list2) where T : IComparable
    {
        if (list1.Count == list2.Count && list1.SequenceEqual(list2))
            return SublistType.Equal;

        if (list1.Count < list2.Count && IsSublistOf(list1, list2))
            return SublistType.Sublist;

        return IsSublistOf(list2, list1) ? SublistType.Superlist : SublistType.Unequal;
    }

    private static bool IsSublistOf<T>(List<T> list1, List<T> list2) where T : IComparable
    {
        if (list1.Count == 0 && list2.Count > 0)
            return true;

        for (int i = list2.IndexOf(list1.First()); i <= list2.Count - list1.Count; i++)
            if (list2.Skip(i).Take(list1.Count).SequenceEqual(list1))
                return true;

        return false;
    }
}
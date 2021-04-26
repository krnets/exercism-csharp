using System;
using System.Collections.Generic;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        int count = 0;

        foreach (var _ in input)
            count++;

        return count;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        var result = new List<T>();

        for (int i = input.Count - 1; i >= 0; i--)
            result.Add(input[i]);

        return result;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        var result = new List<TOut>();

        foreach (var item in input)
            result.Add(map(item));

        return result;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        var result = new List<T>();

        foreach (var item in input)
            if (predicate(item))
                result.Add(item);

        return result;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        var acc = start;

        foreach (var item in input)
            acc = func(acc, item);

        return acc;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        var acc = start;

        for (int i = input.Count - 1; i >= 0; i--)
            acc = func(input[i], acc);

        return acc;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        var result = new List<T>();

        foreach (var list in input)
        {
            foreach (var item in list)
                result.Add(item);
        }

        return result;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        var result = new List<T>();

        foreach (var item in left)
            result.Add(item);

        foreach (var item in right)
            result.Add(item);

        return result;
    }
}
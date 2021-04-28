using System;
using System.Collections.Generic;

public static class VariableLengthQuantity
{
    private static uint UpperLimit = 0b0111_1111;
    private static uint MaxSize = 0b1000_0000;
    private static int Shift = 0b0111;

    public static uint[] Encode(uint[] numbers)
    {
        var list = new List<uint>();

        foreach (var n in numbers)
        {
            if (n < MaxSize)
                list.Add(n);
            else
            {
                var bytes = new LinkedList<uint>();
                var temp = n;

                while (temp > 0)
                {
                    var encoded = temp & UpperLimit;

                    if (bytes.Count == 0)
                        bytes.AddFirst(encoded);
                    else bytes.AddFirst(encoded | MaxSize);

                    temp >>= Shift;
                }

                list.AddRange(bytes);
            }
        }

        return list.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        var list = new List<uint>();

        for (uint i = 0, temp = 0; i < bytes.Length; i++)
        {
            temp = (temp << Shift) | bytes[i] & UpperLimit;

            if ((bytes[i] & MaxSize) == 0)
            {
                list.Add(temp);
                temp = 0;
            }

            else if (i == bytes.Length - 1)
                throw new InvalidOperationException();
        }

        return list.ToArray();
    }
}
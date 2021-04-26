using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        var stack = new Stack();

        foreach (var item in input)
        {
            stack.Push(item);

            while (stack.Count > 0)
            {
                var topOfStack = stack.Pop();

                if (topOfStack is IEnumerable<object> sequence)
                    foreach (var element in sequence.Reverse())
                        stack.Push(element);

                else if (topOfStack != null)
                    yield return topOfStack;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();

        foreach (char c in input.Where(c => Brackets.ContainsKey(c) || Brackets.ContainsValue(c)))
            if (stack.Count > 0 && IsClosing(stack.Peek(), c))
                stack.Pop();
            else stack.Push(c);

        return stack.Count == 0;
    }

    private static Dictionary<char, char> Brackets => new Dictionary<char, char> {{'(', ')'}, {'{', '}'}, {'[', ']'}};

    private static bool IsClosing(char peek, char c) => Brackets.ContainsKey(peek) && Brackets[peek] == c;
}
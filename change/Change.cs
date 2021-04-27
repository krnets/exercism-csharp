using System;
using System.Collections.Generic;
using System.Linq;

public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {
        var changeMap = new Dictionary<int, List<int>> {[0] = new List<int>()};
        var queue = new Queue<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (current == target)
                return changeMap[current].OrderBy(x => x).ToArray();

            foreach (var coin in coins)
            {
                int nextValue = current + coin;

                if (nextValue > target) break;

                if (!changeMap.ContainsKey(nextValue))
                {
                    changeMap[nextValue] = new List<int>(changeMap[current]) {coin};
                    queue.Enqueue(nextValue);
                }
            }
        }

        throw new ArgumentException();
    }
}
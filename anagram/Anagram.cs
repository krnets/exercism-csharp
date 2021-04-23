using System.Linq;

public class Anagram
{
    public Anagram(string baseWord)
    {
        BaseWordLower = baseWord.ToLower();
        BaseWordLowerSorted = BaseWordLower.OrderBy(c => c);
    }

    public string BaseWordLower { get; }
    public IOrderedEnumerable<char> BaseWordLowerSorted { get; }

    public string[] FindAnagrams(string[] potentialMatches) =>
        potentialMatches
            .Where(word => !word.ToLower().Equals(BaseWordLower))
            .Where(word => word.ToLower().OrderBy(c => c).SequenceEqual(BaseWordLowerSorted))
            .ToArray();
}
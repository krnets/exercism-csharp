using System.Text.RegularExpressions;

public static class PigLatin
{
    public static string Translate(string word)
    {
        var firstVowel = new Regex(@"(?<begin>^|\s)(?<vowel>[aeiou]|yt|xr)(?<rest>\w+)");
        var firstVowelReplacement = "${begin}${vowel}${rest}ay";

        var specialCase = new Regex(@"(?<begin>^|\s)(?<consonants>[^aeiou]+)(?<special>y)(?<rest>\w*)");
        var specialCaseReplacement = "${begin}${special}${rest}${consonants}ay";

        var consonants = new Regex(@"(?<begin>^|\s)(?<consonants>ch|qu|thr|th|sch|yt|\wqu|\w)(?<rest>\w+)");
        var consonantsReplacement = "${begin}${rest}${consonants}ay";

        return firstVowel.IsMatch(word)
            ? firstVowel.Replace(word, firstVowelReplacement)
            : specialCase.IsMatch(word)
                ? specialCase.Replace(word, specialCaseReplacement)
                : consonants.Replace(word, consonantsReplacement);
    }
}
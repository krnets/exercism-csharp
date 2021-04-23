using System.Collections.Generic;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var list = new List<string>();

        while (startBottles > 0 && takeDown > 0)
        {
            var verse =
                $"{startBottles} bottle{(startBottles > 1 ? "s" : "")} of beer on the wall, {startBottles} bottle{(startBottles > 1 ? "s" : "")} of beer.\n" +
                $"Take {(startBottles > 1 ? "one" : "it")} down and pass it around, {(startBottles - 1 == 0 ? "no more" : $"{startBottles - 1}")} bottle{(startBottles - 1 == 1 ? "" : "s")} of beer on the wall.\n";

            list.Add(verse);
            startBottles--;
            takeDown--;
        }

        var emptyVerse = "No more bottles of beer on the wall, no more bottles of beer.\n" +
                         "Go to the store and buy some more, 99 bottles of beer on the wall.\n";

        if (startBottles == 0 && takeDown > 0)
            list.Add(emptyVerse);

        return string.Join("\n", list).TrimEnd();
    }
}
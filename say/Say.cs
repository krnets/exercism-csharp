using System;

public static class Say
{
    private static readonly string[] First20 =
    {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
        "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
    };

    private static readonly string[] Tens =
        {"ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

    public static string InEnglish(long number)
    {
        if (number < 0 || number >= 1e12) throw new ArgumentOutOfRangeException();

        if (number < 20) return First20[number];

        if (number < 100)
            return
                $"{(number / 10 > 0 ? $"{Tens[number / 10 - 1]}" : "")}" +
                $"{(number % 10 > 0 ? $"-{InEnglish(number % 10)}" : "")}";

        if (number < 1e3)
            return
                $"{(number / 100 > 0 ? $"{First20[number / 100]} hundred" : "")}" +
                $"{(number % 100 > 0 ? $" {InEnglish(number % 100)}" : "")}";

        if (number < 1e6)
            return
                $"{(number / 1e3 > 0 ? $"{InEnglish(number / (long)1e3)} thousand" : "")}" +
                $"{(number % 1e3 > 0 ? $" {InEnglish(number % (long)1e3)}" : "")}";

        if (number < 1e9)
            return
                $"{(number / 1e6 > 0 ? $"{InEnglish(number / (long)1e6)} million" : "")}" +
                $"{(number % 1e6 > 0 ? $" {InEnglish(number % (long)1e6)}" : "")}";

        return $"{(number / 1e9 > 0 ? $"{InEnglish(number / (long)1e9)} billion" : "")}" +
               $"{(number % 1e9 > 0 ? $" {InEnglish(number % (long)1e9)}" : "")}";
    }
}
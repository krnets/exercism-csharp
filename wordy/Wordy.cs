using System;
using System.Text.RegularExpressions;

public static class Wordy
{
    public static int Answer(string question)
    {
        var pattern = @"^What is " +
                      @"((?<numA>-?\d+)" +
                      @"(?<operation>\s" +
                      @"(?<operand>plus|minus|(multiplied|divided) by|)\s" +
                      @"(?<numB>-?\d+))*)\?$";
        var match = Regex.Match(question, pattern);

        if (!int.TryParse(match.Groups["numA"].Value, out int numA))
            throw new ArgumentException();

        for (int i = 0; i < match.Groups["operation"].Captures.Count; i++)
        {
            if (!int.TryParse(match.Groups["numB"].Captures[i].Value, out int numB))
                throw new ArgumentException();

            var operand = match.Groups["operand"].Captures[i].Value;

            numA = ArithmeticOperation(operand, numA, numB);
        }

        return numA;
    }

    private static int ArithmeticOperation(string operand, int numA, int numB) =>
        operand switch
        {
            "plus" => numA + numB,
            "minus" => numA - numB,
            "multiplied by" => numA * numB,
            "divided by" => numA / numB,
            _ => throw new ArgumentException()
        };
}
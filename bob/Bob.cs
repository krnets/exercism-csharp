using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.IsSilence())
            return "Fine. Be that way!";

        if (statement.IsYell())
            return statement.IsQuestion() ? "Calm down, I know what I'm doing!" : "Whoa, chill out!";

        return statement.IsQuestion() ? "Sure." : "Whatever.";
    }

    private static bool IsSilence(this string statement) => string.IsNullOrWhiteSpace(statement);

    private static bool IsYell(this string statement) => statement.Any(char.IsLetter) &&
                                                         statement.ToUpper() == statement;

    private static bool IsQuestion(this string statement) => statement.TrimEnd().EndsWith('?');
}
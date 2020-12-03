public static class ResistorColor
{
    public static string[] Colors => new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color) => System.Array.IndexOf(ResistorColor.Colors, color);
}
public static class TwoFer
{
    public static string Speak(string v = null)
    {
        return $"One for {v ?? "you"}, one for me.";
    }
}

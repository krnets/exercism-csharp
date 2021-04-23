using System.Linq;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        string[] array = {"wink", "double blink", "close your eyes", "jump"};

        var list = array.Where((_, i) => (commandValue & 1 << i) == 1 << i).ToList();

        if ((commandValue & 1 << 4) == 1 << 4)
            list.Reverse();

        return list.ToArray();
    }
}
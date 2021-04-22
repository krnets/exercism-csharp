using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> UsedNames = new HashSet<string>();

    public string Name { get; private set; }

    public Robot() => Reset();

    public void Reset()
    {
        do Name = generateName();
        while (UsedNames.Contains(Name));

        UsedNames.Add(Name);
    }

    private string generateName()
    {
        var rng = new Random();
        char GetRandomLetter() => (char)('A' + rng.Next(0, 25));
        
        char a = GetRandomLetter();
        char b = GetRandomLetter();
        string c = rng.Next(1000).ToString("000");
        
        return $"{a}{b}{c}";
    }
}
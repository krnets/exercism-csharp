﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

using Exception = System.Exception;

public static class Grep
{
    public static string Match(string pattern, string flags, string[] files)
    {
        var list = new List<string>();

        bool caseInsensitive = false, printFileNamesOnly = false, printLineNumbers = false, invertMatch = false, matchEntireLine = false;
        bool multipleFiles = files.Length > 1;

        foreach (var flag in flags.Split())
        {
            switch (flag)
            {
                case "-i": caseInsensitive = true; break;
                case "-n": printLineNumbers = true; break;
                case "-l": printFileNamesOnly = true; break;
                case "-v": invertMatch = true; break;
                case "-x": matchEntireLine = true; break;
            }
        }

        var regex = new Regex(matchEntireLine ? $"^{pattern}$" : pattern,
            caseInsensitive ? RegexOptions.IgnoreCase : 0);

        foreach (var fileName in files)
        {
            try
            {
                var lines = File.ReadAllLines(fileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (regex.IsMatch(lines[i]) ^ invertMatch)
                    {
                        if (printFileNamesOnly)
                        {
                            list.Add(fileName);
                            break;
                        }

                        list.Add(
                            $"{(multipleFiles ? $"{fileName}:" : "")}{(printLineNumbers ? $"{i + 1}:" : "")}{lines[i]}");
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        return string.Join("\n", list);
    }
}
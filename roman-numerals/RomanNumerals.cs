using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        var map = new SortedDictionary<int, string>
        {
            [1] = "I", [4] = "IV", [5] = "V", [9] = "IX", [10] = "X",
            [40] = "XL", [50] = "L", [90] = "XC", [100] = "C",
            [400] = "CD", [500] = "D", [900] = "CM", [1000] = "M"
        };
        var sb = new StringBuilder();

        foreach (var (num, roman) in map.Reverse())
        {
            while (value / num > 0)
            {
                sb.Append(roman);
                value -= num;
            }
        }

        return sb.ToString();
    }
}
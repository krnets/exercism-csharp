using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant { Violets, Radishes, Clover, Grass }

public class KindergartenGarden
{
    private List<string> children = new List<string>
    {
        "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny",
        "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"
    };

    private readonly string[] _rows;

    public KindergartenGarden(string diagram) => _rows = diagram.Split("\n");

    public IEnumerable<Plant> Plants(string student)
    {
        int i = children.IndexOf(student);
        var str = _rows[0].Substring(i * 2, 2) + _rows[1].Substring(i * 2, 2);

        foreach (var plant in from c in str
            from Plant plant in Enum.GetValues(typeof(Plant))
            where c == plant.ToString()[0]
            select plant)
        {
            yield return plant;
        }
    }
}
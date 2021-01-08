using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly List<Student> _studentRoster = new List<Student>();

    private class Student
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; }
        public int Grade { get; }
    }

    public void Add(string student, int grade) =>
        _studentRoster.Add(new Student(student, grade));

    public IEnumerable<string> Roster() =>
        _studentRoster
            .OrderBy(s => s.Grade)
            .ThenBy(s => s.Name)
            .Select(s => s.Name);

    public IEnumerable<string> Grade(int grade) =>
        _studentRoster
            .Where(s => s.Grade == grade)
            .OrderBy(s => s.Name)
            .Select(s => s.Name);
}
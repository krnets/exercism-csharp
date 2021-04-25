using System;
using System.Linq;

public enum Schedule { Teenth, First, Second, Third, Fourth, Last }

public class Meetup
{
    private ILookup<DayOfWeek, DateTime> dowLookup;

    public Meetup(int month, int year)
    {
        dowLookup = Enumerable.Range(1, DateTime.DaysInMonth(year, month))
            .Select(day => new DateTime(year, month, day))
            .ToLookup(d => d.DayOfWeek);
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var daysOfWeek = dowLookup[dayOfWeek].ToArray();

        return schedule == Schedule.Teenth
            ? daysOfWeek.First(d => d.Day > 12)
            : daysOfWeek[Math.Min((int)schedule, daysOfWeek.Length) - 1];
    }
}
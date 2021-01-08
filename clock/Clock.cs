public struct Clock
{
    public Clock(int hours, int minutes = 0)
    {
        Hours = Mod((hours * 60 + minutes) / 60.0, 24);
        Minutes = Mod(minutes, 60);
    }

    private int Hours { get; }
    private int Minutes { get; }

    private static int Mod(double x, double y) => (int)((x % y + y) % y);

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

    public override string ToString() => $"{Hours:00}:{Minutes:00}";
}
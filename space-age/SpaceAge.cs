using System.Collections.Generic;
using System.Reflection;

public class SpaceAge
{
    private const int SecondsInEarthYear = 31557600;
    private readonly double ageOnEarth;

    Dictionary<string, double> orbitalPeriodMap = new Dictionary<string, double>
    {
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132}
    };

    public SpaceAge(int seconds) => ageOnEarth = (double)seconds / SecondsInEarthYear;

    private double getSpaceAge(string m) => ageOnEarth / orbitalPeriodMap.GetValueOrDefault(m);

    public double OnEarth() => ageOnEarth;

    public double OnMercury() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnVenus() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnMars() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnJupiter() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnSaturn() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnUranus() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));

    public double OnNeptune() => getSpaceAge(MethodBase.GetCurrentMethod().Name.Substring(2));
}
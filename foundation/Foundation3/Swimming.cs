public class Swimming : Activity
{
    private int laps;
    private const double LapLengthInMiles = 50.0 / 1000 * 0.62;  // Each lap is 50 meters, converted to miles

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * LapLengthInMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}

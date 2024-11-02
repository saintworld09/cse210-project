public abstract class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string Date => date;
    public int Minutes => minutes;

    public abstract double GetDistance();  // Abstract methods to be implemented in derived classes
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Minutes} min): Distance {GetDistance():F2} miles, " +
               $"Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

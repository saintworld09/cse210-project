// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int TimesCompleted;
    private int RequiredTimes;

    public ChecklistGoal(string name, string description, int points, int requiredTimes)
        : base(name, description, points)
    {
        TimesCompleted = 0;
        RequiredTimes = requiredTimes;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
    }

    public override int GetPoints()
    {
        int totalPoints = TimesCompleted * Points;
        if (TimesCompleted >= RequiredTimes)
        {
            totalPoints += 500; // Bonus for completing the checklist
        }
        return totalPoints;
    }

    public override string GetStatus()
    {
        return $"[ ] Completed {TimesCompleted}/{RequiredTimes} times";
    }
}

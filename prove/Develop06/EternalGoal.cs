// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        // No need to change IsCompleted
    }

    public override int GetPoints()
    {
        return Points; // Always returns points for each recording
    }

    public override string GetStatus()
    {
        return "[ ]"; // Always shows as incomplete
    }
}

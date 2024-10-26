// SimpleGoal.cs
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        IsCompleted = true; // Mark as completed
    }

    public override int GetPoints()
    {
        return IsCompleted ? Points : 0; // Only return points if completed
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}

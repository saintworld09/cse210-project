// Goal.cs
public abstract class Goal
{
    protected string Name;
    protected string Description;
    protected int Points;
    protected bool IsCompleted;

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract int GetPoints();
    public abstract string GetStatus();

    public string GetName() => Name;
    public string GetDescription() => Description;
}

using System;
using System.Threading;

public class Activity
{
    private string name;
    private string description;
    private int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"{name}\n{description}");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Pause(2);
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
    }

    protected int Duration => duration;
}

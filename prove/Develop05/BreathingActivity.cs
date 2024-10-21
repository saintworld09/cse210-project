using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.")
    {
    }

    public void Start()
    {
        StartActivity();
        int breaths = Duration / 2; // 2 seconds per breath
        for (int i = 0; i < breaths; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }
        EndActivity();
    }
}

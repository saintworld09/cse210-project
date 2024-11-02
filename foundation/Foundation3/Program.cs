using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create sample activities
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 15.0),
            new Swimming("03 Nov 2022", 30, 20)
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

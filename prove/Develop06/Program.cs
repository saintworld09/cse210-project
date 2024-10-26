// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        while (true)
        {
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Show Total Score");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add a Simple Goal
                    Console.Write("Enter goal name: ");
                    string simpleName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string simpleDesc = Console.ReadLine();
                    Console.Write("Enter points for this goal: ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(simpleName, simpleDesc, simplePoints));
                    break;

                case "2":
                    // Add an Eternal Goal
                    Console.Write("Enter goal name: ");
                    string eternalName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string eternalDesc = Console.ReadLine();
                    Console.Write("Enter points for each recording: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(eternalName, eternalDesc, eternalPoints));
                    break;

                case "3":
                    // Add a Checklist Goal
                    Console.Write("Enter goal name: ");
                    string checklistName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string checklistDesc = Console.ReadLine();
                    Console.Write("Enter points for each completion: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter required completions: ");
                    int requiredTimes = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(checklistName, checklistDesc, checklistPoints, requiredTimes));
                    break;

                case "4":
                    // Record an event for a goal
                    Console.WriteLine("Select a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()} - {goals[i].GetStatus()}");
                    }
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    goals[goalIndex].RecordEvent();
                    totalScore += goals[goalIndex].GetPoints();
                    break;

                case "5":
                    // Show goals
                    Console.WriteLine("Goals:");
                    foreach (var goal in goals)
                    {
                        Console.WriteLine($"{goal.GetName()} - {goal.GetStatus()}");
                    }
                    break;

                case "6":
                    // Show total score
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;

                case "7":
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}

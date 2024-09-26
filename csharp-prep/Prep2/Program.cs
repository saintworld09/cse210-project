using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the user passed or not
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep trying, better luck next time!");
        }

        // Stretch Challenge: Adding + or - to the letter grade
        int lastDigit = gradePercentage % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptional cases: no A+ and no F+ or F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // There is no A+
        }
        if (letter == "F")
        {
            sign = ""; // No + or - for F grades
        }

        // Output the letter grade with the sign
        Console.WriteLine($"Your letter grade is {letter}{sign}.");
    }
}

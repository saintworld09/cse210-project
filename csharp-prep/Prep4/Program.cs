using System;
using System.Collections.Generic;
using System.Linq; // For sorting and finding the smallest positive number

class Program
{
    static void Main()
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        int userInput;

        // Inform the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0) // Only add numbers that aren't 0
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        // Core Requirements
        // 1. Compute the sum of the numbers
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average of the numbers
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // 3. Find the largest number in the list
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        // 1. Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // 2. Sort the numbers and display the sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

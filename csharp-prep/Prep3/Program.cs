using System;

class Program
{
    static void Main()
    {
        // Initialize the random number generator
        Random random = new Random();
        
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            int guess = -1;

            // Inform the user about the game
            Console.WriteLine("Welcome to the Guess My Number game!");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Give feedback: Higher, Lower, or Correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} attempts!");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            // Check if the user wants to play again
            playAgain = (response == "yes");
        }

        // End of the game
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}

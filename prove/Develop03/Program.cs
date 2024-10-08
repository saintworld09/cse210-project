using System;

public class Program
{
    public static void Main(string[] args)
    {
        string scriptureText = "For God so loved the world that he gave his only begotten Son";
        Scripture scripture = new Scripture("John 3:16", scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.AreAllWordsHidden())
            {
                Console.Clear();
                scripture.DisplayScripture();
                Console.WriteLine("All words are now hidden. Memorization complete!");
                break;
            }
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Understanding Abstraction", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Thanks for the clarity."));
        video1.AddComment(new Comment("Charlie", "This helped a lot!"));

        Video video2 = new Video("C# for Beginners", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "Very informative!"));
        video2.AddComment(new Comment("Eve", "I learned a lot."));
        video2.AddComment(new Comment("Frank", "Nice tutorial!"));

        Video video3 = new Video("OOP Concepts", "Sarah Johnson", 600);
        video3.AddComment(new Comment("Grace", "Excellent content!"));
        video3.AddComment(new Comment("Heidi", "Well explained!"));
        video3.AddComment(new Comment("Ivan", "Looking forward to more!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(); // Blank line for better readability
        }
    }
}

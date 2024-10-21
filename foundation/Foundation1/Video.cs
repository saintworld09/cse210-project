using System.Collections.Generic;

public class Video
{
    // Properties follow PascalCase naming conventions
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    private List<Comment> comments; // Encapsulated comment list

    // Constructor for initializing a video
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the total number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Returns a copy of the comments to preserve encapsulation
    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }
}

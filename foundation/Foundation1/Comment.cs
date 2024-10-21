public class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    // Constructor to initialize a comment
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

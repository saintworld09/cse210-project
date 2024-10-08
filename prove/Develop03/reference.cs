public class Reference
{
    public string ReferenceText { get; private set; }

    public Reference(string reference)
    {
        ReferenceText = reference;
    }

    public void Display()
    {
        Console.WriteLine(ReferenceText);
    }
}

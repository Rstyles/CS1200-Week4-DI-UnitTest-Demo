namespace UnitTestDemo.Models;

public class Note
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public Note(string title, bool isComplete = false)
    {
        Title = title;
        IsCompleted = isComplete;
    }
}

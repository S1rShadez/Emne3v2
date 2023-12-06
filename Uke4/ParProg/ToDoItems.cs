using System.Reflection.Metadata;

namespace ParProg;

public class ToDoItems
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }

    public ToDoItems(string title, string description, bool completed)
    {
        Title = title;
        Description = description;
        Completed = completed;
    }
}
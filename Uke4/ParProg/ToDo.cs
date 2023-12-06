namespace ParProg;

public class ToDo
{
    List<ToDoItems> ToDoList {get; set; }

    public ToDo()
    {
        ToDoList = new List<ToDoItems>();
    }

    public string SeeAllTasks()
    {
        string allTasks = "";
        int i = 1;
        foreach (var item in ToDoList)
        {
            allTasks += $"{i++}. " + item.Title + "\n";
        }

        return allTasks;
    }

    public void AddTask(ToDoItems item)
    {
        ToDoList.Add(item);
        Console.WriteLine($"{item.Title} was successfully added to your ToDo list");
    }

    public void DeleteTask(int selection)
    {
        Console.WriteLine($"{ToDoList[selection-1].Title} was successfully removed");
        ToDoList.RemoveAt(selection-1);
    }

    public string TaskDetails(int selection)
    {
        Console.Clear();
        return $"Title: {ToDoList[selection].Title}\nDescrtiption: {ToDoList[selection].Description}\nCompleted: {ToDoList[selection].Completed}";
    }

    public void CompleteTask(int selection)
    {
        ToDoList[selection].Completed = true;
        Console.WriteLine($"{ToDoList[selection].Title} is completed");
    }
}
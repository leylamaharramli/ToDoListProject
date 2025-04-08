namespace ToDoListProject.Models;

public abstract class TaskBase
{
    public int ID { get; set; }
    public string Title { get; set; }
    public bool isCompleted { get; set; } = false;
    private static int Count = 1;

    protected TaskBase(string title)
    {
        Title = title;
        ID = Count++;
    }

    public virtual void Print()
    {
        Console.WriteLine("");
    }
}


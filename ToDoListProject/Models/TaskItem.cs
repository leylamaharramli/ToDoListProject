namespace ToDoListProject.Models;

public class TaskItem : TaskBase
{
    public TaskItem(string title) : base(title)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"{ID}. Title: {Title}, isCompleted: {isCompleted}");
        //Console.WriteLine(ID);
        //Console.Write(Title);
        //Console.Write(isCompleted);
    }
}

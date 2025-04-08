namespace ToDoListProject.Models;

public class WrongInputException : Exception
{
    public WrongInputException() : base("Duzgun secim daxil edilmeyib")
    {

    }
}

public class TaskNotFoundException : Exception
{
    public TaskNotFoundException() : base("Task tapilmadi")
    {

    } 
}

public class TaskAlreadyFinishedException : Exception
{
    public TaskAlreadyFinishedException() : base("Task artiq tamamlanib")
    {

    }
}

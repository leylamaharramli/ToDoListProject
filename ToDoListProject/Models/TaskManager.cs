using System.Threading.Tasks;

namespace ToDoListProject.Models;

static class TaskManager
{

    static TaskItem[] Tasks = new TaskItem[0];

    public static TaskItem[] RemoveTask(int id)
    {
        TaskItem[] NewTasks = new TaskItem[Tasks.Length-1];
        int index = 0;
        foreach (var item in Tasks)
        {
            if (item.ID == id)
            {
                continue;
            }
            if (index<NewTasks.Length)
            {
                NewTasks[index++] = item;
            } 
        }
        Console.WriteLine("Task siyahidan silindi");
        Tasks = NewTasks;
        return NewTasks;
        throw new TaskNotFoundException();
    }




    public static void AddTask(string name)
    {
        TaskItem task = new TaskItem(name);

        Array.Resize(ref Tasks, Tasks.Length + 1);
        Tasks[^1] = task;
        Console.WriteLine($"{name} taski yaradildi");
    }

    public static void ShowTasks()
    {
        for (int i = 0; i < Tasks.Length; i++)
        {
            Tasks[i].Print();
        }
    }

  
    public static bool FinishTask(int id)
    {
        foreach (var item in Tasks)
        {
            if (item.ID == id)
            {
                if (item.isCompleted==false)
                {
                    item.isCompleted =! item.isCompleted; 
                }
                else
                {
                    throw new TaskAlreadyFinishedException();
                }

                Console.WriteLine("Task yerine yetirildi");
                return item.isCompleted;
            }
        }
        throw new TaskNotFoundException();
    }

}

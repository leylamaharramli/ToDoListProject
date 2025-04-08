using ToDoListProject.Models;

namespace ToDoListProject;

public class Program
{
    static void Main()
    {
        while (true)
        {
                Console.WriteLine("[1] Yeni tapsiriq elave et");
                Console.WriteLine("[2] Tapsiriqlari goster");
                Console.WriteLine("[3] Tapsirigi tamamla");
                Console.WriteLine("[4] Tapsirigi sil");
                Console.WriteLine("[5] Cixis et");

                string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Tapsirigin adini daxil edin:");
                        string name = Console.ReadLine();
                        TaskManager.AddTask(name);
                        break;

                    case "2":
                        TaskManager.ShowTasks();
                        break;

                    case "3":
                        Console.WriteLine("ID daxil edin");
                        int id = int.Parse(Console.ReadLine());
                        TaskManager.FinishTask(id);
                        break;

                    case "4":
                        Console.WriteLine("ID daxil edin");
                        int id1 = int.Parse(Console.ReadLine());
                        TaskManager.RemoveTask(id1);
                        break;

                    case "5":
                        Console.WriteLine("Bye bye...");
                        return;

                    default:
                        throw new WrongInputException(); 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }

}



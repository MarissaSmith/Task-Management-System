// Program.cs
class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter task name: ");
                    string? taskName = Console.ReadLine();
                    Console.Write("Enter task description: ");
                    string? description = Console.ReadLine();

                    Task newTask = new Task
                    {
                        TaskName = taskName,
                        Description = description,
                        IsCompleted = false
                    };

                    taskManager.AddTask(newTask);
                    break;

                // ... (rest of the switch cases)

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}


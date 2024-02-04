// Program.cs (Task Manager Project)
using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. Display Tasks");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter task title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();

                    Task taskToAdd = new Task { Title = title, Description = description };
                    taskManager.AddTask(taskToAdd);
                    break;

                case "2":
                    Console.Write("Enter task title to mark as completed: ");
                    string titleToMark = Console.ReadLine();
                    taskManager.MarkTaskAsCompleted(titleToMark);
                    break;

                case "3":
                    taskManager.DisplayTasks();
                    break;

                case "4":
                    Console.WriteLine("Exiting the Task Manager. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}



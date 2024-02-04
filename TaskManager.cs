// TaskManager.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void MarkTaskAsCompleted(string title)
    {
        Task task = tasks.FirstOrDefault(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (task != null)
        {
            task.IsCompleted = true;
        }
        else
        {
            Console.WriteLine($"Task with title '{title}' not found.");
        }
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Tasks:");

        foreach (var task in tasks)
        {
            Console.WriteLine($"Title: {task.Title}, Description: {task.Description}, Completed: {task.IsCompleted}");
        }
    }
}

// TaskManager.cs
using System;
using System.Collections.Generic;

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
        Console.WriteLine("Task added successfully!");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    public void MarkTaskAsCompleted(string taskName)
    {
        var task = tasks.Find(t => t.TaskName == taskName);

        if (task != null)
        {
            task.IsCompleted = true;
            Console.WriteLine($"Task '{taskName}' marked as completed!");
        }
        else
        {
            Console.WriteLine($"Task '{taskName}' not found.");
        }
    }
}

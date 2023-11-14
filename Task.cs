// Task.cs
public class Task
{
    public string? TaskName { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"Task: {TaskName}\nDescription: {Description}\nCompleted: {IsCompleted}\n";
    }
}


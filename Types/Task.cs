using Testpr.Enums;

namespace Testpr.Types;


class Task
{

    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime GeneratedDate { get; set; }

    public DateTime DueDate { get; set; }

    public TaskPriority Priority { get; set; }

    public Task(string title, string description, DateTime dueDate, TaskPriority priority)
    {
        Title = title;
        Description = description;
        GeneratedDate = DateTime.Now;
        DueDate = dueDate;
        Priority = priority;
    }


}
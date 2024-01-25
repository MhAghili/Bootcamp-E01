﻿
namespace Testpr.Types;



class ToDoList
{
    public List<Task> tasks { get; set; } = new();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void ShowToDoList()
    {
        foreach (var item in tasks)
        {
            Console.WriteLine($"Title: {item.Title} \nDescription: {item.Description} \nGenerated Date: {item.GeneratedDate} \nDue Date: {item.DueDate} \nPriority: {item.Priority}");
        }
        Console.WriteLine("----------------------------------------------------");
    }

    public void SortList()
    {
        tasks = tasks.OrderBy(o => o.DueDate.Date).ThenBy(o => (int)o.Priority).ToList();
    }
    public void ShowMostImportantTask()
    {
        SortList();
        Console.WriteLine($"Description{tasks[0].Description} \nDue Date: {tasks[0].DueDate.Date} \nPriority: {tasks[0].Priority} \n");
    }
}

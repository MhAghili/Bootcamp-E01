using System.Runtime.InteropServices;
using Testpr.Types;


ToDoList toDoList = new ToDoList();


// Read from json file
string jsonContent = File.ReadAllText("Data/Task.json"); //using vscode,
toDoList.AddJsonTask(jsonContent);

// sort tasks
toDoList.SortList();


// LINQ:
// 1: number of all task

var numberOfAllTask = toDoList.tasks.Count();
Console.WriteLine($" Number of all task: {numberOfAllTask} ");


// 3: number of completed task

var numOfCompletedTasks = toDoList.tasks.Where(task => task.CompletedDate != null)
                                        .Count();
Console.WriteLine($" Number of completed task: {numOfCompletedTasks} ");

// 4: number of completed task from 13.2.2024 to 18.2.2024

var numberOfCopletedTaskFromTo = toDoList.tasks.Where(task => task.CompletedDate != null && task.CompletedDate > DateTime.Parse("2024-2-13") && task.CompletedDate < DateTime.Parse("2024-2-18"))
                                               .Count();
Console.WriteLine($" Number of completed task from 13.2.2024 to 18.2.2024: {numberOfCopletedTaskFromTo} ");


// 5: number of expired task

var numberOfExpiredTask = toDoList.tasks.Where(task => task.DueDate < DateTime.Now).Count();
Console.WriteLine($" Number of expired task: {numberOfExpiredTask} ");

// 6: last 3 tasks that 5 days have passed since it was created and not complted

var last3Tasks = toDoList.tasks.Where(task => task.GeneratedDate.AddDays(5) < DateTime.Now && task.CompletedDate == null)
                               .Take(3)
                               .ToList();


// 7: last 3 that completed on generat date:

var last3TasksCompletedOnGenDate = toDoList.tasks.Where(task => task.CompletedDate != null && task.GeneratedDate == task.CompletedDate)
                                                 .ToList();

// 8: uncompleted tasks ordered by priority

var uncompletedTasks = toDoList.tasks.Where(task => task.CompletedDate == null).OrderBy(task => (int)task.Priority)
                      .ToList();


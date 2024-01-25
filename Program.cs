using Testpr.Types;
using System.Text.Json;

ToDoList toDoList = new ToDoList();

string jsonContent = File.ReadAllText("Data/Task.json"); //using vscode,

var jsonTasks = JsonSerializer.Deserialize<List<JsonTask>>(jsonContent);
if (jsonTasks != null)
{
    foreach (var jsonTask in jsonTasks)
    {
        var task = new Testpr.Types.Task(jsonTask.Title, jsonTask.Description, jsonTask.DueDate, jsonTask.Priority);
        toDoList.AddTask(task);
    }
}


toDoList.ShowMostImportantTask();








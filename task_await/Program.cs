
// Run a task asynchronously
using task_await;

var task = WorkerMethod();
Console.WriteLine(task.Result);
Console.WriteLine(task.IsFaulted);
Console.WriteLine(task.IsCompleted);
// Main thread continues execution
Console.WriteLine("Main thread");


Task<int> WorkerMethod()
{
    Console.WriteLine("Worker thread. Returned something");
    //return Task.CompletedTask;
    return Task.FromResult(3);

    List<LearningCenterScedule> learning CenterScedule = new()
    {
        new (),
        new ()
    };
    learningCenterScedule.
}
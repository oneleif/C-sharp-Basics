using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class AsyncBasics
{
    public static void RunAsyncTask()
    {
        // Introduced in .NET 4.5
        Task.Run(CallerWithAsync);
        Console.WriteLine("i am waiting");
    }

    // async modifier is used. async methods can only return Task or void
    private async static void CallerWithAsync()
    {
        // await is used before a method call. It suspends execution of CallerWithAsync()
        // method and control returns to the calling thread that can perform other task.
        // we MUST "await" an "awaitable" type: Task, Task<T>, or a custom "awaitable" type
        string result = await GreetingAsync();

        // this line would not be executed before  GetSomethingAsync() method completes
        Console.WriteLine(result);
    }

    static Task<string> GreetingAsync()
    {
        return Task.Run<string>(() =>
        {
            return Greeting();
        });
    }

    static string Greeting()
    {
        // Simulate the method taking 2 seconds
        Thread.Sleep(2000);
        return "hello!";
    }
}

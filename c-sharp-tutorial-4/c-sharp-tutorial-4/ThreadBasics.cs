using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class ThreadBasics
{
    public static void StartThread()
    {
        // Do something in a new thread
        Thread thread = new Thread(TaskOne);
        // Start "TaskOne" in another thread
        thread.Start();

        Thread parameterizedThread = new Thread(TaskWithParam);
        parameterizedThread.Start("thread parameter");

        Console.WriteLine("test");
        // Do other tasks in the main thread
    }

    public static void StartDirectThread()
    {
        new Thread(TaskOne).Start();
    }

    public static void StartLambdaThread()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Lambda thread task");
        });

        thread.Start();
    }

    public static void StartControlledThread()
    {
        // Do something in a new thread
        Thread thread = new Thread(TaskOne);
        // Start "TaskOne" in another thread
        thread.Start();
        thread.Name = "My new thread"; // Used to identify the currently running thread
        thread.IsBackground = false; // Make this a foreground thread, manually created threads are by-default, foreground.
        thread.Priority = ThreadPriority.Highest; // Set high priority thread
        // Do other tasks in the main thread
    }

    static void TaskOne()
    {
        Console.WriteLine("TaskOne");
    }


    // Has to be passed as an "object" and casted to the type required
    static void TaskWithParam(object output)
    {
        Console.WriteLine(output);
    }
}

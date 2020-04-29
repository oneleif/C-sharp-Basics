using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class ThreadExamples
{
    public static void GetPcInfo()
    {
        int minimumWorkerThreadCount, minimumIOCThreadCount;
        int logicalProcessorCount = System.Environment.ProcessorCount;
        ThreadPool.GetMinThreads(out minimumWorkerThreadCount, out minimumIOCThreadCount);
        Console.WriteLine("No.of processors: " + logicalProcessorCount);
        Console.WriteLine("Minimum no.of Worker threads: " + minimumWorkerThreadCount);
        Console.WriteLine("Minimum no.of IOCP threads: " + minimumIOCThreadCount);
    }

    public static void RunThreads()
    {
        WriteX(); // Call WriteX() on the main thread

        // Create a new thread, call WriteY() on the new thread
        // The CLR assigns each thread its own memory stack so the local variables have their own scope
        Thread y = new Thread(WriteY);
        // Changes the thread to running
        y.Start();
        Thread z = new Thread(WriteZ);
        z.Start();
        //z.Join(1000); // wait for Z to finish, don't use any CPU resources
        //Thread a = new Thread(WriteA);
        //a.Start();
        //WriteW();
    }

    static void WriteA()
    {
        for (int i = 0; i < 1000; i++) Console.Write("a");
    }

    static void WriteW()
    {
        for (int i = 0; i < 1000; i++) Console.Write("w");
    }

    static void WriteX()
    {
        for (int i = 0; i < 1000; i++) Console.Write("x");
    }

    static void WriteY()
    {
        Thread.Sleep(1000); // Tell the current thread to wait 1000ms (1 second)
        for (int i = 0; i < 1000; i++) Console.Write("y");
    }

    static void WriteZ()
    {
        for (int i = 0; i < 1000; i++) Console.Write("z");
    }
}

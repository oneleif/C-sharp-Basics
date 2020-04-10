using System;
using System.Threading;

class TimeManager
{
    public static int hoursPassed = 0;
    public static void WaitOneHour()
    {
        Console.WriteLine(hoursPassed);
        Thread.Sleep(1000);
        hoursPassed++;
    }
}

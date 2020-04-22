using System;
using System.Collections.Generic;
using System.Text;

class DelegateExamples
{
    // Delegate are essentially Function Pointers (if you are familiar with C++), they allow functions to be passed as as parameters
    // Delegates are commonly used to define callbacks and handle responding to events
    // They "Delegate" out tasks to those that are their children

    public delegate void PrintMessage(string message);

    public static void DelegateBasics()
    {
        // Instantiate the delegate
        PrintMessage printHandler = MethodForPrintDelegate;
        // Add another listener to the delegate's invocation list
        printHandler += PrintDelegateMessage;

        // Call the delegate, telling each of it's listeners to do their task
        printHandler("i am handling a print");

        // Remove a listener
        printHandler -= MethodForPrintDelegate;
        printHandler("i only have one listener now");
    }

    private static void MethodForPrintDelegate(string message)
    {
        Console.WriteLine("PrintMessage delegate was called");
    }

    private static void PrintDelegateMessage(string message)
    {
        Console.WriteLine(message);
    }
}

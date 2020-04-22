using System;
using System.Collections.Generic;
using System.Text;

class EventManager
{
    public EventManager()
    {
        Publisher publisher = new Publisher();
        publisher.CustomEvent += CustomEventSubscriber;
        publisher.CustomEvent += CustomEventSubscriber2;

        string userInput = Console.ReadLine();
        publisher.RaiseCustomEvent(userInput);

    }

    private void CustomEventSubscriber(object sender, CustomEventArgs args)
    {
        Console.WriteLine($"sender: {sender} \n args: {args} \n message: {args.eventMessage}");
    }

    private void CustomEventSubscriber2(object sender, CustomEventArgs args)
    {
        Console.WriteLine($"im another subscriber");
    }
}

using System;
using System.Collections.Generic;
using System.Text;

class EventManager
{

    public enum InputValues
    {
        Start, moveup, movedown
    }

    public EventManager()
    {
        Publisher publisher = new Publisher();
        publisher.CustomEvent += PlayerInputSubscriber;

        

        while (true)
        {
            string userInput = Console.ReadLine();
            publisher.RaiseCustomEvent(userInput);
        }
        

    }

    private void PlayerInputSubscriber(object sender, CustomEventArgs args)
    {
        if(args.eventMessage == "start")
        {

        }
    }
}

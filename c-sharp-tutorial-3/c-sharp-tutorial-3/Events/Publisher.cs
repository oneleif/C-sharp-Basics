using System;
using System.Collections.Generic;
using System.Text;

class Publisher
{
    // Events enable a class/object to notify other classes/objects when something happens
    // The class that sends to the event is the Publisher, the class that receives/handles the event are Subscribers
    // Events are typically used for user interaction, for example when a button is clicked or a key is pressed
    // If an event has multiple subscribers, they are invoked synchronously

    public delegate void CustomEventHandler(object send, CustomEventArgs args);

    public event CustomEventHandler CustomEvent;


    public void RaiseCustomEvent(string message)
    {
        if(CustomEvent != null)
        {
            CustomEvent(this, new CustomEventArgs(message));
        }
    }
    
}

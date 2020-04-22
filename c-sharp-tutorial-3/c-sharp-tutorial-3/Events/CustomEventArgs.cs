using System;
using System.Collections.Generic;
using System.Text;

public class CustomEventArgs
{
    public CustomEventArgs(string s) { eventMessage = s; }
    public String eventMessage { get; private set; } //readonly
}

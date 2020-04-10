using System;

class Lion : Animal
{

    public Lion() : base()
    {
        hoursToHungry = 10;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("ROAR");
    }
}
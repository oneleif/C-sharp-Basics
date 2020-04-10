using System;

class Cheetah : Animal
{
    public Cheetah() : base()
    {
        hoursToHungry = 10;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("growl");
    }

    public override bool CheckHungry()
    {
        hoursSinceFeeding++;
        return base.CheckHungry();
    }
}
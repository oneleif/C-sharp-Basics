using System;

class Dog : Animal
{

    public Dog() : base()
    {
        hoursToHungry = 3;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("woof");
    }
}

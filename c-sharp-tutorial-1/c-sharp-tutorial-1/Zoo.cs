using System;
using System.Collections.Generic;

class Zoo
{
    static void Main(string[] args)
    {
        List<IPrintable> things = new List<IPrintable>();

        while (true)
        {
            TimeManager.WaitOneHour();
            foreach(Animal animal in Zoo)
            {
                CheckAnimalIsHungry(animal);
            }
        }
    }

    static void CheckAnimalIsHungry(Animal myAnimal)
    {
        if (myAnimal.CheckHungry())
        {
            myAnimal.FeedAnimal();
        }
    }
}
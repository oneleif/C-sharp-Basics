using System;
using System.Collections.Generic;

class Zoo
{
    static void Main(string[] args)
    {
        List<Animal> Zoo = new List<Animal>();
        Zoo.Add(new Lion());
        Zoo.Add(new Dog());
        Zoo.Add(new Cheetah());

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
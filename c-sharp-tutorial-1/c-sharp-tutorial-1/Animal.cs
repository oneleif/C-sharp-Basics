using System;
abstract class Animal
{
    private bool isHungry;
    protected float hoursToHungry;
    public float hoursSinceFeeding;

    public Animal()
    {
        isHungry = false;
    }


    public abstract void MakeNoise();


    public virtual bool CheckHungry()
    {
        hoursSinceFeeding++;
        isHungry = hoursSinceFeeding >= hoursToHungry;

        if (isHungry)
        {
            MakeNoise();
        }

        return isHungry;
    }
    
    public void FeedAnimal()
    {
        hoursSinceFeeding = 0;
    }
}

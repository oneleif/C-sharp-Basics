using System;
abstract class Animal : IPrintable
{
    private bool isHungry;
    protected float hoursToHungry;
    public float hoursSinceFeeding;

    public Animal()
    {
        isHungry = false;
    }




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

    public void MakeNoise()
    {
        throw new NotImplementedException();
    }
}

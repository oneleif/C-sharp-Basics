using System;
using System.Collections.Generic;
using System.Text;

class CollectionsBasics
{
    //from System.Collections.Generic
    // Two ways to group objects: arrays and collections
    // Arrays: create and work with a fixed number of strongly-typed objects
    // Collections: a class that allows for generic, dynamically-sized storage of objects
    // A Generic Collection enforces type safety, so you know the type when retrieving data

    public static void ListExample()
    {
        List<float> lengths = new List<float>() { 0.75f } ;
        lengths.Add(1.0f);
        lengths.Add(2.5f);
        lengths.Add(4.0f);

        float totalLength = 0;

        // You can use a foreach to iterate through any collection
        lengths.ForEach(number => totalLength += number);
        //foreach (float length in lengths)
        //{
        //    totalLength += length;
        //}

        Console.WriteLine(totalLength);

        lengths[0] = 500f;
        float[] lengthsArray = lengths.ToArray();
        int numberOfLengths = lengths.Count;

        lengths.Remove(0.75f);

        
    }

    public class Student
    {
        public string name;
        public int percentage;
    }
    public static void DictionaryExample()
    {
        Dictionary<int, Student> studentScores;
        studentScores = new Dictionary<int, Student>();
        studentScores.Add(0, new Student());
        studentScores.Add(1, new Student());
        studentScores.Add(2, new Student());

        int averageScore = 0;
        foreach(KeyValuePair<int, Student> student in studentScores)
        {
            averageScore += student.Value.percentage;
        }

        averageScore /= studentScores.Count;
        Console.WriteLine($"average student scores: {averageScore}");
    }


    public static void HashSetExample()
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        uniqueNumbers.Add(1);
        uniqueNumbers.Add(2);
        uniqueNumbers.Add(3);
        uniqueNumbers.Add(1);
    }

    

    public static void StackExample()
    {
        Queue<int> lineNumbers = new Queue<int>();
        Stack<int> stack = new Stack<int>();
    }

    //others: SortedDictionary, SortedList, SortedSet

    int[] test = new int[] { 1, 2, 3 };
}

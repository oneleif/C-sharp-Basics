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
        List<float> lengths = new List<float> { 0.5f, 0.75f };
        lengths.Add(1.0f);
        lengths.Add(2.5f);
        lengths.Add(4.0f);

        float totalLength = 0;

        // You can use a foreach to iterate through any collection
        foreach(float length in lengths)
        {
            totalLength += length;
        }

        Console.WriteLine(totalLength);

        lengths[0] = 500f;
        float[] lengthsArray = lengths.ToArray();
        int numberOfLengths = lengths.Count;

        lengths.Remove(0.75f);
        lengths.ForEach(number => Console.WriteLine(number));
    }


    public static void DictionaryExample()
    {
        Dictionary<string, int> studentScores;
        studentScores = new Dictionary<string, int>();
        studentScores.Add("adam", 100);
        studentScores.Add("steve", 80);
        studentScores.Add("john", 93);

        int averageScore = 0;
        foreach(KeyValuePair<string, int> student in studentScores)
        {
            averageScore += student.Value;
        }

        averageScore /= studentScores.Count;
        Console.WriteLine($"average student scores: {averageScore}");
    }


    HashSet<int> uniqueNumbers;

    Queue<int> lineNumbers;
    Stack<int> stack;

    //others: SortedDictionary, SortedList, SortedSet

    int[] test = new int[] { 1, 2, 3 };
}

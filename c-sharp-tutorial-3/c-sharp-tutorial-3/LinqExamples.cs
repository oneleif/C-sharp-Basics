using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// LINQ == Language INtegrated Query
// LINQ queries can filter, sort, group collections
// LINQ is a way to query multiple different data sources (objects, databases, and XML) with one syntax
class LinqExamples
{
    public static void GetSquares()
    {
        int[] numbers = { 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(x => x * x); // Uses LINQ
        Console.WriteLine(string.Join(",", squaredNumbers));
    }

    public static void GetFuncSquares()
    {
        int[] numbers = { 2, 3, 4, 5 };

        Func<int, int> squareNumbers = x => x * x;
        var squaredNumbers = numbers.Select(param => squareNumbers(param)); // Uses LINQ
        Console.WriteLine(string.Join(" ", squaredNumbers));
    }

    public static void GetEvenCount()
    {
        int[] numbers = { 2, 3, 4, 5 };
        int evenCount = numbers.Count(n => n % 2 == 0); // Uses LINQ
        Console.WriteLine($"there are {evenCount} evens in {string.Join(" ", numbers)} ");
    }

    public static void TestScores()
    {
        // Create a data source
        int[] scores = new int[] { 55, 99, 100, 72, 93, 85, 79 };

        // Create the query... All collections inherit from IEnumerable or IEnumerable<T>
        // IEnumerable interface exposes an enumerator, which allows you to iterate over the type. You could make your own Enumerable
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        // Execute the query. Queries aren't executed until you iterate over them.
        foreach(int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}

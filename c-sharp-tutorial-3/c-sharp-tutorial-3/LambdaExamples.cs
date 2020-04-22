using System;
using System.Collections.Generic;
using System.Text;

class LambdaExamples
{
    delegate void TestDelegate(string s);

    static void OldDelegate(string s)
    {
        Console.WriteLine(s);
    }

    public static void LambdaVersions()
    {
        // Original delegate syntax required
        // initialization with a named method.
        TestDelegate testDelA = new TestDelegate(OldDelegate);

        // C# 2.0: A delegate can be initialized with
        // inline code, called an "anonymous method." This
        // method takes a string as an input parameter.
        TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

        // C# 3.0. A delegate can be initialized with
        // a lambda expression. The lambda also takes a string
        // as an input parameter (x). The type of x is inferred by the compiler.
        TestDelegate testDelC = (x) => { Console.WriteLine(x); };

        // Invoke the delegates.
        testDelA("Hello. My name is OldDelegate and I write lines.");
        testDelB("I'm an anonymous function");
        testDelC("I'm a lambda delegate");

        // Keep console window open in debug mode.
        Console.ReadKey();
    }

    public static void LambdaBasics()
    {
        // Lambda 
        // (params) => expression
        // OR
        // (params) => { statements }

        var array = new int[] { 10, 20, 30 };
        // Takes in: (array, predicate)
        var findElement = Array.Find(array, element => element == 20);
        Console.WriteLine(findElement);
    }

    public static void ExpressionLambdaTypes()
    {
        int x = 2;
        int y = 3;


        // "Action": a delegate (pointer) to a function, accepts 0 or more params, but does NOT return
        Action printLine = () => Console.WriteLine("i am an action");
        printLine();

        // "Func": a delegate (pointer) to a function, accepts 0 or more params, DOES return something
        Func<int, int> selfSum = param1 => param1 + param1;
        int result = selfSum(x);

        // two or more params requires parentheses around the params
        Func<int, int, double> pow = (param1, param2) => Math.Pow(param1, param2);
        double powResult = pow(x, y);

        // "Predicate" : a Func used for validation, returns bool
        Predicate<int> IsPositive = param => param >= 0;
        bool isXPositive = IsPositive(x);


        Console.ReadKey();
    }

    public static void StatementLambdaTypes()
    {
        int x = 2;
        int y = 3;

        Action printLine = () => Console.WriteLine("i am an action");
        printLine();

        Func<int, int> selfSum = param1 => {
            int sum = param1 + param1;
            return sum;
        };

        int result = selfSum(x);

        Func<int, int, double> pow = (param1, param2) => {
            double exponent = Math.Pow(param1, param2);
            return exponent;
        };
        double powResult = pow(x, y);

        Console.ReadKey();
    }
}

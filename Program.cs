using System;

class Program
{
    static void Main()
    {
        // Action<T> — void return, has parameters
        Action<string> print = msg => Console.WriteLine(msg);
        print("Hello from Action!");

        // Action — void return, no parameters
        Action sayHi = () => Console.WriteLine("Hi!");
        sayHi();

        // Func<T, TResult> — always returns a value
        Func<int, int, int> add      = (a, b) => a + b;
        Func<string, int>   getLength = s => s.Length;

        Console.WriteLine(add(3, 4));          // 7
        Console.WriteLine(getLength("Hello")); // 5

        // Predicate<T> — always returns bool
        Predicate<int>    isEven = n => n % 2 == 0;
        Predicate<string> isLong = s => s.Length > 5;

        Console.WriteLine(isEven(4));        // True
        Console.WriteLine(isLong("Hi"));     // False
        Console.WriteLine(isLong("Hello!")); // True
    }
}
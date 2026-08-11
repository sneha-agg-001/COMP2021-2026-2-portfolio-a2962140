using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Alice", "Smith", 21);

        Console.WriteLine(person.FullName());
        Console.WriteLine($"Adult: {person.IsAdult()}");
    }
}
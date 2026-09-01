string[] names =
[
    "Sneha",
    "Aman",
    "Priya",
    "Christopher",
    "Raj",
    "Anjali",
    "Michael",
    "Simran",
    "Alexander",
    "Sam"
];

foreach (string name in names)
{
    Console.WriteLine(name);
}

string longest = names[0];
string shortest = names[0];

foreach (string name in names)
{
    if (name.Length > longest.Length)
    {
        longest = name;
    }

    if (name.Length < shortest.Length)
    {
        shortest = name;
    }
}

Console.WriteLine("Longest name: " + longest);
Console.WriteLine("Shortest name: " + shortest);

Console.WriteLine("Before sorting:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Sort(names);

Console.WriteLine("After sorting:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("Before reversing:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);

Console.WriteLine("After reversing:");

foreach (string name in names)
{
    Console.WriteLine(name);
}
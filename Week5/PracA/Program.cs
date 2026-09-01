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

// Task 1: Print all names
Console.WriteLine("Names:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Find longest and shortest names
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

// Sort the array
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

// Reverse the array
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


// Task 2: Using Lists

List<string> students = new List<string>();

// Add
students.Add("John");
students.Add("Emma");
students.Add("Liam");

// Remove
students.Remove("Emma");

// Insert
students.Insert(1, "Olivia");

// AddRange
students.AddRange([
    "Noah",
    "Ava",
    "Mia",
    "Lucas",
    "Sofia",
    "Ethan",
    "Isla",
    "Jack"
]);

Console.WriteLine("Students:");

foreach (string student in students)
{
    Console.WriteLine(student);
}

// Search for an exact name
int index = students.IndexOf("John");

Console.WriteLine($"John is at index: {index}");

// Search for partial name
Console.WriteLine("Names containing 'a':");

foreach (string student in students)
{
    if (student.Contains("a", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine(student);
    }
}

// Sum the length of all names
int totalLength = 0;

foreach (string student in students)
{
    totalLength += student.Length;
}

Console.WriteLine($"Total length of all names: {totalLength}");

// Convert Array to List
List<string> namesList = names.ToList();

Console.WriteLine("Array converted to List:");

foreach (string name in namesList)
{
    Console.WriteLine(name);
}

// Convert List to Array
string[] namesArray = students.ToArray();

Console.WriteLine("List converted to Array:");

foreach (string name in namesArray)
{
    Console.WriteLine(name);
}
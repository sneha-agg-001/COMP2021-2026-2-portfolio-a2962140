static LinkedList<Person> ToLinkedList(List<Person> people)
{
    LinkedList<Person> result = new LinkedList<Person>();

    foreach (Person person in people)
    {
        result.AddLast(person);
    }

    return result;
}


static string PrintPeople(LinkedList<Person> people)
{
    string result = "";

    foreach (Person person in people)
    {
        result += $"{person.FullName} - {person.Age}\n";
    }

    return result;
}


static LinkedList<Person> SortPeople(LinkedList<Person> people)
{
    LinkedList<Person> sorted = new LinkedList<Person>();

    foreach (Person person in people)
    {
        if (sorted.First == null)
        {
            sorted.AddFirst(person);
        }
        else
        {
            LinkedListNode<Person>? current = sorted.First;

            while (current != null && current.Value.Age < person.Age)
            {
                current = current.Next;
            }

            if (current == null)
            {
                sorted.AddLast(person);
            }
            else
            {
                sorted.AddBefore(current, person);
            }
        }
    }

    return sorted;
}


List<Person> people = new List<Person>();

people.Add(new Person("Sneha", "Agg", 26));
people.Add(new Person("Aman", "Kumar", 22));
people.Add(new Person("Priya", "Sharma", 19));
people.Add(new Person("Raj", "Singh", 31));
people.Add(new Person("Anjali", "Patel", 17));
people.Add(new Person("Michael", "Brown", 45));
people.Add(new Person("Simran", "Kaur", 21));
people.Add(new Person("Alexander", "Jones", 12));
people.Add(new Person("Emma", "Wilson", 28));

Person fred = new Person("Fred", "Smith", 21);
people.Add(fred);

LinkedList<Person> linkedPeople = ToLinkedList(people);

Console.WriteLine("LinkedList:");

foreach (Person person in linkedPeople)
{
    Console.WriteLine($"{person.FullName} - {person.Age}");
}

Console.WriteLine();
Console.WriteLine("People:");

foreach (Person person in people)
{
    Console.WriteLine($"{person.FullName} - {person.Age}");
}


Console.WriteLine();
Console.WriteLine("Using PrintPeople:");

string output = PrintPeople(linkedPeople);
Console.WriteLine(output);



LinkedList<Person> sortedPeople = SortPeople(linkedPeople);

Console.WriteLine("Sorted by age:");
Console.WriteLine(PrintPeople(sortedPeople));



fred.Age = 30;

Console.WriteLine("After changing Fred's age to 30:");

Console.WriteLine("Fred in List:");
Console.WriteLine($"{fred.FullName} - {fred.Age}");

Console.WriteLine("Fred in LinkedList:");

foreach (Person person in linkedPeople)
{
    if (person.FullName == "Fred, Smith")
    {
        Console.WriteLine($"{person.FullName} - {person.Age}");
    }
}
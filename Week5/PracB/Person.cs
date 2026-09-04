public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public double Age
    {
        get;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age can't be less than 0");
            }

            field = value;
        }
    }

    public string FullName => $"{FirstName}, {LastName}";

    public Person(string firstName, string lastName, double age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}
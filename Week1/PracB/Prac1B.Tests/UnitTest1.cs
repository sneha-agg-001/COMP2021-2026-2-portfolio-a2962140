using Xunit;

public class PersonTests
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Alice", "Smith", 20);

        string result = person.FullName();

        Assert.Equal("Smith, Alice", result);
    }


    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Alice", "Smith", 18);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}
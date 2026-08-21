using Xunit;

public class EmployeeTests
{
    [Fact]
    public void FullTimeEmployee_CalculatePay_ReturnsAfterTax()
    {
        var employee = new FullTimeEmployee
        {
            Name = "Bill",
            AnnualSalary = 6250
        };

        decimal result = employee.CalculatePay();

        Assert.Equal(5000, result);
    }

    [Fact]
    public void Contractor_CalculatePay_ReturnsAfterTax()
    {
        var employee = new Contractor
        {
            Name = "Fred",
            Rate = 25,
            Hours = 100
        };

        decimal result = employee.CalculatePay();

        Assert.Equal(2000, result);
    }

    [Fact]
    public void FullTimeEmployee_GenerateReport_ReturnsCorrectReport()
    {
        var employee = new FullTimeEmployee
        {
            Name = "Bill",
            AnnualSalary = 6250
        };

        string result = employee.GenerateReport();

        Assert.Equal("Bill: Pay $5000.0. Tax $1250.0.", result);
    }

    [Fact]
    public void Contractor_GenerateReport_ReturnsCorrectReport()
    {
        var employee = new Contractor
        {
            Name = "Fred",
            Rate = 25,
            Hours = 100
        };

        string result = employee.GenerateReport();

        Assert.Equal("Fred: Pay $2000.0. Tax $500.0.", result);
    }
}
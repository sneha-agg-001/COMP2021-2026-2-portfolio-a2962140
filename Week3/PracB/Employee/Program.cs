List<Employee> employees = new List<Employee>
{
    new FullTimeEmployee
    {
        Name = "Bill",
        AnnualSalary = 6250
    },

    new Contractor
    {
        Name = "Fred",
        Rate = 25,
        Hours = 100
    }
};

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.CalculatePay());

    if (employee is IReportable reportable)
    {
        Console.WriteLine(reportable.GenerateReport());
    }
}
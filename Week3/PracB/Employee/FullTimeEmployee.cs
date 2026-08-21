public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary { get; set; }

    public override decimal CalculatePay()
    {
        return AnnualSalary - (AnnualSalary * TaxRate);
    }

    public string GenerateReport()
    {
        decimal tax = AnnualSalary * TaxRate;
        decimal pay = CalculatePay();

        return $"{Name}: Pay ${pay}. Tax ${tax}.";
    }
}
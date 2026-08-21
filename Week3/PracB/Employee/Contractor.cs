public class Contractor : Employee, IReportable
{
    public decimal Rate { get; set; }

    public decimal Hours { get; set; }

    public override decimal CalculatePay()
    {
        decimal grossPay = Rate * Hours;

        return grossPay - (grossPay * TaxRate);
    }

    public string GenerateReport()
    {
        decimal grossPay = Rate * Hours;
        decimal tax = grossPay * TaxRate;
        decimal pay = CalculatePay();

        return $"{Name}: Pay ${pay}. Tax ${tax}.";
    }
}
using System;

class Program
{
    static void Main()
    {
        Payroll payroll = new Payroll(38, 42.50m, 0.20m);

        Console.WriteLine($"Net pay: ${payroll.CalculateNetPay():F2}");

        payroll.ChangeTaxRate(0.25m);

        Console.WriteLine(
            $"Net pay after tax rate change: ${payroll.CalculateNetPay():F2}"
        );
    }
}
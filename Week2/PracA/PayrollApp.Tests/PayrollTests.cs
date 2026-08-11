using System;
using Xunit;

public class PayrollTests
{
    [Fact]
    public void CalculateNetPay_ReturnsCorrectAmount()
    {
        Payroll payroll = new Payroll(38, 42.50m, 0.20m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(1292.00m, result);
    }

    [Fact]
    public void ChangeTaxRate_ChangesNetPay()
    {
        Payroll payroll = new Payroll(38, 42.50m, 0.20m);

        payroll.ChangeTaxRate(0.25m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(1211.25m, result);
    }

    [Fact]
    public void Constructor_ThrowsException_WhenHoursAreNegative()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(-1, 42.50m, 0.20m)
        );
    }

    [Fact]
    public void Constructor_ThrowsException_WhenRateIsNegative()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(38, -42.50m, 0.20m)
        );
    }

    [Fact]
    public void Constructor_ThrowsException_WhenTaxRateIsNegative()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(38, 42.50m, -0.20m)
        );
    }

    [Fact]
    public void Constructor_ThrowsException_WhenTaxRateIsAboveOne()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(38, 42.50m, 1.20m)
        );
    }

    [Fact]
    public void ChangeTaxRate_ThrowsException_WhenTaxRateIsInvalid()
    {
        Payroll payroll = new Payroll(38, 42.50m, 0.20m);

        Assert.Throws<ArgumentException>(() =>
            payroll.ChangeTaxRate(1.20m)
        );
    }
}
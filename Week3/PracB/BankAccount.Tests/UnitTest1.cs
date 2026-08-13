using System;
using Xunit;
using BankAccountClass = global::BankAccount.BankAccount;

namespace BankAccount.Tests;

public class BankAccountTests
{
    [Fact]
    public void Constructor_SetsOwnerAndBalance()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Equal("Sneha", account.Owner);
        Assert.Equal(1000m, account.Balance);
    }

    [Fact]
    public void Deposit_Decimal_IncreasesBalance()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        account.Deposit(250m);

        Assert.Equal(1250m, account.Balance);
    }

    [Fact]
    public void Deposit_Int_IncreasesBalance()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        account.Deposit(200);

        Assert.Equal(1200m, account.Balance);
    }

    [Fact]
    public void Deposit_Double_IncreasesBalance()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        account.Deposit(50.50);

        Assert.Equal(1050.50m, account.Balance);
    }

    [Fact]
    public void Deposit_Zero_ThrowsException()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Throws<ArgumentException>(() => account.Deposit(0m));
    }

    [Fact]
    public void Deposit_Negative_ThrowsException()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Throws<ArgumentException>(() => account.Deposit(-100m));
    }

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        account.Withdraw(300m);

        Assert.Equal(700m, account.Balance);
    }

    [Fact]
    public void Withdraw_TooMuch_ThrowsException()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Throws<InvalidOperationException>(
            () => account.Withdraw(1500m));
    }

    [Fact]
    public void Withdraw_Zero_ThrowsException()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Throws<ArgumentException>(
            () => account.Withdraw(0m));
    }

    [Fact]
    public void Withdraw_Negative_ThrowsException()
    {
        var account = new BankAccountClass("Sneha", 1000m);

        Assert.Throws<ArgumentException>(
            () => account.Withdraw(-100m));
    }
}
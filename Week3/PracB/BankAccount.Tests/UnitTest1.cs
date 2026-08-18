public class BankAccountTests
{
    [Fact]
    public void Deposit_IncreasesBalance()
    {
        var account = new BankAccount("Sneha", 1000m);

        account.Deposit(200m);

        Assert.Equal(1200m, account.Balance);
    }

    [Fact]
    public void Deposit_RejectsZero()
    {
        var account = new BankAccount("Sneha", 1000m);

        Assert.Throws<ArgumentException>(() => account.Deposit(0m));
    }

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccount("Sneha", 1000m);

        account.Withdraw(200m);

        Assert.Equal(800m, account.Balance);
    }

    [Fact]
    public void Withdraw_RejectsInsufficientFunds()
    {
        var account = new BankAccount("Sneha", 100m);

        Assert.Throws<InvalidOperationException>(
            () => account.Withdraw(200m)
        );
    }

    [Fact]
    public void Withdraw_RejectsZero()
    {
        var account = new BankAccount("Sneha", 1000m);

        Assert.Throws<ArgumentException>(
            () => account.Withdraw(0m)
        );
    }

    [Fact]
    public void SavingsAccount_StoresInterestRate()
    {
        var account = new SavingsAccount("Sneha", 1000m, 3.5m);

        Assert.Equal(3.5m, account.InterestRate);
    }

    [Fact]
    public void SavingsAccount_AppliesInterest()
    {
        var account = new SavingsAccount("Sneha", 1000m, 10m);

        account.ApplyInterest();

        Assert.Equal(1100m, account.Balance);
    }

    [Fact]
    public void CheckingAccount_StoresTransactionFee()
    {
        var account = new CheckingAccount("Sneha", 1000m, 5m);

        Assert.Equal(5m, account.TransactionFee);
    }

    [Fact]
    public void CheckingAccount_WithdrawsTransactionFee()
    {
        var account = new CheckingAccount("Sneha", 1000m, 5m);

        account.Withdraw(100m);

        Assert.Equal(895m, account.Balance);
    }

    [Fact]
    public void DisplayAccountInfo_DoesNotThrow()
    {
        var savings = new SavingsAccount("Sneha", 1000m, 3.5m);
        var checking = new CheckingAccount("Sneha", 1000m, 5m);

        savings.DisplayAccountInfo();
        checking.DisplayAccountInfo();
    }
}
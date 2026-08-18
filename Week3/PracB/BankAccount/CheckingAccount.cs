public class CheckingAccount : BankAccount
{
    public decimal TransactionFee { get; set; }

    public CheckingAccount(string owner, decimal balance, decimal transactionFee)
        : base(owner, balance)
    {
        TransactionFee = transactionFee;
    }

    public override void Withdraw(decimal amount)
    {
        base.Withdraw(amount);
        Balance -= TransactionFee;
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: CheckingAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: ${Balance:F2}");
        Console.WriteLine($"Transaction fee: ${TransactionFee:F2}");
    }
}
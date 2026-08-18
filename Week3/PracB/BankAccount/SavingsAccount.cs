public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string owner, decimal balance, decimal interestRate)
        : base(owner, balance)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate / 100;
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: SavingsAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: ${Balance:F2}");
        Console.WriteLine($"Interest rate: {InterestRate:F1}%");
    }
}
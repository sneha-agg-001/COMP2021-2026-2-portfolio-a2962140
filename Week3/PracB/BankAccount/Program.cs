public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }

    public virtual void DisplayAccountInfo()
    {
        Console.WriteLine("Account: BankAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: ${Balance:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Savings Account ===");

        SavingsAccount savings = new SavingsAccount(
            "Sneha",
            1500m,
            3.5m
        );

        savings.DisplayAccountInfo();

        savings.ApplyInterest();

        Console.WriteLine();
        Console.WriteLine("After applying interest:");
        savings.DisplayAccountInfo();

        Console.WriteLine();
        Console.WriteLine("=== Checking Account ===");

        CheckingAccount checking = new CheckingAccount(
            "Sneha",
            1000m,
            5m
        );

        checking.DisplayAccountInfo();

        checking.Withdraw(100m);

        Console.WriteLine();
        Console.WriteLine("After withdrawing $100:");
        checking.DisplayAccountInfo();
    }
}
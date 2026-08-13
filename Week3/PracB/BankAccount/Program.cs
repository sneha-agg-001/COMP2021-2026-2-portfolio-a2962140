using System;

namespace BankAccount;

public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal balance = 0)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public void Deposit(int amount)
    {
        Deposit((decimal)amount);
    }

    public void Deposit(double amount)
    {
        Deposit((decimal)amount);
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("Sneha", 1000m);

        Console.WriteLine("=== Bank Account Demo ===");
        Console.WriteLine($"Owner: {account.Owner}");
        Console.WriteLine($"Starting balance: ${account.Balance:F2}");

        account.Deposit(200m);
        Console.WriteLine($"After decimal deposit ($200.00): ${account.Balance:F2}");

        account.Deposit(100);
        Console.WriteLine($"After int deposit ($100): ${account.Balance:F2}");

        account.Deposit(50.50);
        Console.WriteLine($"After double deposit ($50.50): ${account.Balance:F2}");

        account.Withdraw(150m);
        Console.WriteLine($"After withdrawal ($150.00): ${account.Balance:F2}");

        Console.WriteLine("Bank account demonstration completed successfully.");
    }
}
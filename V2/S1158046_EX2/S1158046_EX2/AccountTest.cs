using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Tom Bruice", 30.55m);
        Account account2 = new Account("John Wayne", -20.88m);

        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: NT${account2.Balance}");

        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1.balance");
        account1.Deposit(depositAmount);
        Console.WriteLine($"\n{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2.balance");
        account2.Deposit(depositAmount);
        Console.WriteLine($"\n{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Write("Enter Withdrawal amount for account1: ");
        decimal WithdrawalAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1.balance\n");
        account1.Withdraw(WithdrawalAmount);
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Write("Enter Withdrawal amount for account2: ");
        WithdrawalAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2.balance");
        account1.Withdraw(WithdrawalAmount);
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Read();
    }
}

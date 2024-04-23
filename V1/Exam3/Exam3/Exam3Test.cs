using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

class Exam3Test
{
    static void Main()
    {
        Exam3 account1 = new Exam3("Tom Bruice", 30.55m);
        Exam3 account2 = new Exam3("John Wayne", -20.88m);

        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:c}");

        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse( Console.ReadLine());
        Console.WriteLine(
            $"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount);

        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");
        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse( Console.ReadLine());
        Console.WriteLine(
            $"adding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount);

        Console.Write("\nEnter withdraw amount for account1: ");
        decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {withdrawalAmount:C} to account1 balance\n");
        account1.Withdraw(withdrawalAmount);

        Console.Write("\nEnter withdraw amount for account2: ");
        withdrawalAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {withdrawalAmount:C} to account2 balance\n");
        account2.Withdraw(withdrawalAmount);

        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");

        Console.Read();
    }
}

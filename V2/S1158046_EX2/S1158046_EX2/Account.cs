using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    public string Name { get; set; }
    private decimal balance;

    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        balance = initialBalance;
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }

    public void Withdraw(decimal withdrawalAmount)
    {
        if (withdrawalAmount > Balance)
        {
            Console.WriteLine("\nWithdrawal amount exceeded account balance");
        }
        else
        {
            Balance = Balance - withdrawalAmount;
        }
    }
}

using System;

public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Счет паполнен на: {amount}");
        }
        else
        { 
            Console.WriteLine("Сумма пополнения должна быть положительной.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Снято: {amount}");
        }
        else
        {
            Console.WriteLine("Ошибка: недостаточно средств на счёте!");
        }
    }

    public void ShowBalance()
    { 
        Console.WriteLine($"Баланс: {balance}");
    }
}


public class Program
{
    static void Main()
    {
        var account = new BankAccount();

        account.Deposit(1000);
        account.ShowBalance();  

        account.Withdraw(400);  
        account.ShowBalance();  

        account.Withdraw(800);  
        account.ShowBalance();  
    }
}



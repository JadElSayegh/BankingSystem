using System;

class Program
{
    static decimal balance = 0;

    static void Main()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Deposit();
                    break;

                case "2":
                    Withdraw();
                    break;

                case "3":
                    ShowBalance();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n=== BANK MENU ===");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }

    static void Deposit()
    {
        Console.Write("Enter deposit amount: ");

        try
        {
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }

            balance += amount;

            Console.WriteLine($"Deposited {amount}");
        }
        catch
        {
            Console.WriteLine("Invalid number.");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter withdrawal amount: ");

        try
        {
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            balance -= amount;

            Console.WriteLine($"Withdrew {amount}");
        }
        catch
        {
            Console.WriteLine("Invalid number.");
        }
    }

    static void ShowBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}
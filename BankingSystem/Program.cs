using System;

class Program
{
    static decimal balance = 0;
    static string accountName = "";

    static void Main()
    {
        bool running = true;

        while (running)
        {

            Console.WriteLine("\n=== Welcome to the Bank!===");
            Console.WriteLine("Enter Your Account Name: ");

            try
            {
                accountName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(accountName))
                {
                    Console.WriteLine("Account name cannot be empty.");
                    continue;
                }

            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }

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
                    Transfer();
                    break;

                 case "4":
                    accInfo();
                    break;

                case "5":
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
        Console.WriteLine($"\n==={accountName}'s BANK MENU ===");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Transfer");
        Console.WriteLine("4. Account Info");
        Console.WriteLine("5. Exit");
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

    static void Transfer()
    {
        Console.WriteLine("Enter transfer amount: ");

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

    static void accInfo()
    {
        Console.WriteLine($"\n=== Account Information ===");
        Console.WriteLine($"Account Name: {accountName}");
        Console.WriteLine($"Current Balance: {balance}");
    }
}
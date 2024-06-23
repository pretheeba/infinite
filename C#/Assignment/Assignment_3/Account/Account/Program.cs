using System;

public class Accounts
{
    // Data members/fields
    private long accountNo;
    private string customerName;
    private string accountType;
    private double balance;

    // Constructor to initialize the account details
    public Accounts(long accountNo, string customerName, string accountType)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.balance = 0; // Start with zero balance
    }

    // Method to display account information
    public void ShowData()
    {
        Console.WriteLine($"Account Number: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Balance: {balance}");
    }

    // Function to handle deposit
    public void Credit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit of {amount} successful. New balance: {balance}");
    }

    // Function to handle withdrawal
    public void Debit(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal of {amount} successful. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance. Withdrawal failed.");
        }
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        // Input variables
        long accountNo;
        string customerName, accountType;
        double amount;
        string exitOption; // To store user choice to exit

        do
        {
            // Get input from user for account details
            Console.WriteLine("Enter Account Number:");
            while (!long.TryParse(Console.ReadLine(), out accountNo))
            {
                Console.WriteLine("Invalid input. Please enter a valid Account Number:");
            }

            Console.WriteLine("Enter Customer Name:");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter Account Type:");
            accountType = Console.ReadLine();

            // Create an instance of Accounts
            Accounts myAccount = new Accounts(accountNo, customerName, accountType);

            int option;
            do
            {
                // Prompt user for transaction type
                Console.WriteLine("Enter 1 for deposit or 2 for withdrawal:");
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter 1 for deposit or 2 for withdrawal:");
                }

                switch (option)
                {
                    case 1:
                        // Deposit
                        Console.WriteLine("\nEnter amount to deposit:");
                        while (!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount:");
                        }
                        myAccount.Credit(amount);
                        break;

                    case 2:
                        // Withdrawal
                        Console.WriteLine("\nEnter amount to withdraw:");
                        while (!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount:");
                        }
                        myAccount.Debit(amount);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter 1 for deposit or 2 for withdrawal.");
                        break;
                }

                // Display updated account details
                myAccount.ShowData();

                // Ask user if they want to perform another transaction
                Console.WriteLine("\nDo you want to perform another transaction? (yes/no)");
                exitOption = Console.ReadLine().ToLower();

            } while (exitOption == "yes");

            Console.WriteLine("Thank you for using our services. Goodbye!");

        } while (true); // To ensure the program restarts if the user wants to perform another account transaction
    }
}

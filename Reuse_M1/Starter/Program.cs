using Reuse_M1;
using System.Globalization;

class Program
{
    static void Main()
    {
        //create BankCustomer objects
        string firstName = "Tim";
        string lastName = "Shao";

        Console.WriteLine($"Creating a BankCustomer object for customer {firstName} {lastName}...");
        BankCustomer customer1 = new BankCustomer(firstName, lastName);

        //Task 1: /review the code files in the starter project
        // Task 2: Create derived classes (CheckingAccount, SavingsAccount, and MoneyMarketAccount)


        // Step 1 - Create account objects using the base and derived classes - BankAccount, CheckingAccount, SavingsAccount, and MoneyMarketAccount
        //instatiate derived classes
        Console.WriteLine($"\nUsing derived classes to create bank account objects for {customer1.ReturnFullName()}");
        // BankAccount bankAccount1 = new BankAccount(customer1.CustomerId, 1000, "Checking");
        CheckingAccount checkingAccount1 = new CheckingAccount(customer1.CustomerId, 500);
        SavingsAccount savingsAccount1 = new SavingsAccount(customer1.CustomerId, 1000);
        MoneyMarketAccount moneyMarketAccount1 = new MoneyMarketAccount(customer1.CustomerId, 2000);

        // Step 2 - Demonstrate using inherited properties to display account information
        Console.WriteLine($"\nUsing inherited properties to display {customer1.ReturnFullName()}'s account information...");
        // Console.WriteLine($" - {bankAccount1.AccountType} account #{bankAccount1.AccountNumber} has a balance of {bankAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        Console.WriteLine($" - {checkingAccount1.AccountType}account #{checkingAccount1.AccountNumber} has a balance of {checkingAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        Console.WriteLine($" - {savingsAccount1.AccountType} account #{savingsAccount1.AccountNumber} has a balance of {savingsAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        Console.WriteLine($" - {moneyMarketAccount1.AccountType} account #{moneyMarketAccount1.AccountNumber} has a balance of {moneyMarketAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");

        // Step 3 - Demonstrate using inherited methods to withdraw, transfer, and deposit funds
        Console.WriteLine("\nDemonstrating inheritance of the Withdraw, Transfer, and Deposit methods from the base class...");

        //define a transaction amount
        double transactionAmount = 200;

        // Withdraw from checking account, transfer from savings account to checking account, and deposit into money market account
        Console.WriteLine($" - Withdraw {transactionAmount} from {checkingAccount1.AccountType} account");
        checkingAccount1.Withdraw(transactionAmount);

        Console.WriteLine($" - Transfer {transactionAmount.ToString("C", CultureInfo.CurrentCulture)} from {savingsAccount1.AccountType} accunt");
        savingsAccount1.Transfer(checkingAccount1, transactionAmount);

        Console.WriteLine($" - Deposit {transactionAmount.ToString("C", CultureInfo.CurrentCulture)} into {moneyMarketAccount1.AccountType} account");
        moneyMarketAccount1.Deposit(transactionAmount);

        Console.WriteLine($" - {checkingAccount1.AccountType} account #{checkingAccount1.AccountNumber} has a balance of {checkingAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        Console.WriteLine($" - {savingsAccount1.AccountType} account #{savingsAccount1.AccountNumber} has a balance of {savingsAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
        Console.WriteLine($"- {moneyMarketAccount1.AccountType} account #{moneyMarketAccount1.AccountNumber} has a balance of {moneyMarketAccount1.Balance.ToString("C", CultureInfo.CurrentCulture)}");
    }
}
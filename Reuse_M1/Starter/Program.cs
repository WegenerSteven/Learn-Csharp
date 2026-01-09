using Reuse_M1;
using System.Globalization;

class Program
{
    static void main()
    {
        //create BankCustomer objects
        string firstName = "Tim";
        string lastName = "Shao";

        Console.WriteLine($"Creating a BankCustomer object for customer {firstName} {lastName}...");
        BankCustomer customer1 = new BankCustomer(firstName, lastName);

        
    }
}
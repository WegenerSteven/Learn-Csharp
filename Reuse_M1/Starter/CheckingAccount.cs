using System;

namespace Reuse_M1;

public class CheckingAccount : BankAccount
{

    //public static properties with private setters for default overdraft limit and default interest rate
    public static double DefaultOverdraftLimit { get; private set; }
    public static double DefaultInterestRate { get; private set; }

    //public property for overdraft limit
    public double OverdraftLimit { get; set; }

    static CheckingAccount()
    {
        DefaultOverdraftLimit = 500;
        DefaultInterestRate = 0.0;
    }

    //constructor to access base class constructor
    public CheckingAccount(string customerIdNumber, double balance = 200, double overdraftLimit = 500) : base(customerIdNumber, balance, "Checking")
    {
        OverdraftLimit = overdraftLimit;

    }

}
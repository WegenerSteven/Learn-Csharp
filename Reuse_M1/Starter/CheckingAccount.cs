using System;

namespace Reuse_M1;

public class CheckingAccount: BankAccount
{
    //constructor to access base class constructor
    public CheckingAccount(string customerId, double initialBalance) : base(customerId, initialBalance,"Checking")
    {
        
    }

}
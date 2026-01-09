using System;

namespace Reuse_M1;

public class SavingsAccount: BankAccount
{
    public SavingsAccount(string customerId, double initialBalance): base(customerId, initialBalance, "Savings")
    {
        
    }
}

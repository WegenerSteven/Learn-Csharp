using System;

namespace Reuse_M1;

public class MoneyMarketAccount: BankAccount
{
    public MoneyMarketAccount(string customerId, double initialBalance): base(customerId, initialBalance, "Money Market")
    {
        
    }

}

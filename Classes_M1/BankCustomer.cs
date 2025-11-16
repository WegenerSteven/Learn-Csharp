using System;

namespace Classes_M1;

public class BankCustomer
{

    private static int s_nextcustomerId;
    //add public fields
    public string FirstName = "Benard";
    public string LastName = "Steven";
    public readonly string CustomerId;
    //parameterless constructor

    //static constructor
    static BankCustomer()
    {
        Random random = new Random();
        s_nextcustomerId = random.Next(1000, 2000);
    }


    public BankCustomer()
    {
        this.CustomerId = (s_nextcustomerId++).ToString("D5");
    }

    //constructor 2
    public BankCustomer(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
        this.CustomerId = (s_nextcustomerId++).ToString("D5");
    }
}

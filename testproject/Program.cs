using System;

//-------------1---------------------
//create method to display random numbers
// Console.WriteLine("Generating numbers");
// DisplayRandomNumbers();


// void DisplayRandomNumbers()
// {
//     Random random = new Random();

//     for (int i = 0; i < 20; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }
//     Console.WriteLine();
// }

//code reuse - methods

//-------------2---------------------

// int[] times = { 200, 800, 1600, 2000, 100, 5000 };

// int diff = 0; 

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }

// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /*Format and display medicine times*/
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time}");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes()
// {
//     //Adjust the times by adding the difference keeping the value within 24 hrs
//     for(int i = 0; i<times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// -------------------3 -------------------------------
/*
Suppose you're a candidate in a coding interview. The interviewer wants you to write a program that checks whether an IPv4 address is valid or invalid. You're given the following rules:

A valid IPv4 address consists of four numbers separated by dots
Each number must not contain leading zeroes
Each number must range from 0 to 255
1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.

The IPv4 address is provided as a string. You can assume that it only consists of digits and dots (there are no letters in the string provided).

How would you approach this task?
*/


//pseudocode
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

//variables to store input and validation statuses
// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength();
//     ValidateRange();
//     ValidateZeroes();

//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }


// void ValidateLength()
// {
//     validLength = address.Length == 4;
// }

// void ValidateRange()
// {
//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// void ValidateZeroes()
// {
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }
//     validZeroes = true;
// }

//-----------4-------------------
/* Code challenge */

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
// string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
// string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
// string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// Console.WriteLine("A fortune teller whispers the following words:");
// FortuneTeller();

// void FortuneTeller()
// {
//     string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]}");
//     }
//     return;
// }

/*-------------5------------
class inheritance and polymorphism
*/

// HousePet mypet1 = new Dog();
// HousePet mypet2 = new Cat();

// Console.WriteLine(mypet1.Speak());
// Console.WriteLine(mypet2.Speak());


// public class HousePet
// {
//     public virtual string Speak()
//     {
//         return "Hello";
//     }
// }

// public class Dog : HousePet
// {
//     public override string Speak()
//     {
//         return "woof";
//     }
// }

// public class Cat : HousePet
// {
//     public override string Speak()
//     {
//         return "Meow";
//     }
// }

//transitive nature of inheritance in C#

// public class Vehicle
// {
//     public string Make { get; set; }
//     public string Model { get; set; }

//     public void StartEngine()
//     {
//         Console.WriteLine("Engine started.");
//     }

//     public void StopEngine()
//     {
//         Console.WriteLine("Engine stopped");
//     }
// }

// public class Car : Vehicle
// {
//     public int NumberOfDoors { get; set; }

//     public void OpenTrunk()
//     {
//         Console.WriteLine("Trunk opened");
//     }

//     public void HonkHorn()
//     {
//         Console.WriteLine("Horn honked");
//     }

//     public void LockDoors()
//     {
//         Console.WriteLine("Doors locked");
//     }
// }

// public class ElectricCar : Car
// {
//     public int BatteryCapacity { get; set; }

//     public void chargeBattery()
//     {
//         Console.WriteLine("Battery charging");
//     }

//     public void DisplayBatterystatus()
//     {
//         Console.WriteLine("Battery status displayed");
//     }
// }

// public class CombustionEngineCar : Car
// {
//     public int FuelCapacity { get; set; }

//     public void Refuel()
//     {
//         Console.WriteLine("Car Refueled.");
//     }

//     public void CheckOilLevel()
//     {
//         Console.WriteLine("Oil level checked");
//     }
// }

//----------------Examine the use of the abstract keyword-----------------

// public abstract class Shape //base abstract class
// {
//     public abstract int GetArea(); //abstract method
// }

// public class Square : Shape
// {
//     private int _side;

//     public Square(int side)
//     {
//         _side = side;
//     }

//     public override int GetArea()
//     {
//         return _side * _side;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Square square = new Square(5);
//         Console.WriteLine($"Area of the square = {square.GetArea()}");
//     }
// }
/**-----------Examine the use of the virtual keyword----------*/

// public class Animal
// {
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Animal makes a sound");
//     }
// }

// public class Dog: Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Animal animal = new Dog();
//         animal.MakeSound();
//     }
// }

public class BaseClass
{
    public virtual void method1()
    {
        Console.WriteLine("Method1 in BaseClass");
    }

    public virtual void Method2()
    {
        Console.WriteLine("Method2 in BaseClass");
    }
}

public class DerivedClass : BaseClass
{
    public sealed override void method1()
    {
        Console.WriteLine("Method1 in DerivedClass");
    }

    public override void Method2()
    {
        Console.WriteLine("Method2 in DerivedClass");
    }
}

public class FinalClass : DerivedClass
{
    //this can't override method1 because it's sealed in DerivedClass
    public override void Method2()
    {
        Console.WriteLine("Method2 in Finalclass");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
        DerivedClass final = new FinalClass();
        final.Method2();
    }
}


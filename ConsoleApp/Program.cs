// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y through constructor
//         int y; //Non-Static or Instance Variable

//         //Constructor
//         public Program(int a)
//         {
//             //Initializing non-static variable
//             y = a;
//         }

//         static void Main(string[] args)
//         {
//             //Accessing the static variable without instance
//             Console.WriteLine($"x value: {x}");
//             //Accessing the constant variable without instance
//             Console.WriteLine($"PI value: {PI}");

//             Program obj1 = new Program(300);
//             Program obj2 = new Program(400);
//             //Accessing Non-Static variable using instance
//             Console.WriteLine($"obj1 y value: {obj1.y}");
//             Console.WriteLine($"obj2 y value: {obj2.y}");
//             Console.Read();
//         }
//     }
// }

//readonly variables - example one

// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y through constructor
//         int y; //Non-Static or Instance Variable
//         readonly int z; //Readonly Variable

//         //Constructor
//         public Program(int a)
//         {
//             //Initializing non-static variable
//             y = a;
//         }

//         static void Main(string[] args)
//         {
//             //Accessing the static variable without instance
//             Console.WriteLine($"x value: {x}");
//             //Accessing the constant variable without instance
//             Console.WriteLine($"PI value: {PI}");

//             Program obj1 = new Program(300);
//             Program obj2 = new Program(400);
//             //Accessing Non-Static variable using instance
//             Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
//             Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");
//             Console.Read();
//         }
//     }
// }

//example two
using System;
namespace TypesOfVariables
{
    internal class Program
    {
        const float PI = 3.14f; //Constant Variable
        static int x = 100; //Static Variable
        //We are going to initialize variable y through constructor
        int y; //Non-Static or Instance Variable
        readonly int z; //Readonly Variable

        //Constructor
        public Program(int a, int b)
        {
            //Initializing non-static variable
            y = a;
            //Initializing Readonly variable
            z = b;
        }

        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");

            Program obj1 = new Program(300, 45);
            Program obj2 = new Program(400, 55);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
            Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");
            Console.Read();
        }
    }
}
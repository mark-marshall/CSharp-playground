using System;

namespace Leaarning_C
{
    class Program
    {
        enum Ages : int
        {
            Ben = 12,
            Steve = 14,
            James = 12,
            Bob = 32,
        }
        static void Main(string[] args)
        // Main is the entry point for any programme
        // static means we can invoke this function without an instance of the class: Program
        // void means that we are not returning anything in this method
        {
            // print hello world
            Console.WriteLine("Hello World!");
            // print all of the arguments passed to Main
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            // variable assigment and parameterisation order in WriteLine
            int myInt = 16;
            int myIntTwo = 12;
            Console.WriteLine("Age of student: {0}\nAge of second student: {1}", myInt, myIntTwo);
            // multiple assigment
            int a, b, c, d;
            a = b = c = d = 10;
            Console.WriteLine(d);
            // implicit versus explicit casting
            short myShort = 5;
            int myInteger = myShort; // implicit -> just tells compiler to avoid type checks
            int myIntegerI;
            double myDouble = 4.7;
            myIntegerI = (int)myDouble; // explicit -> actually converts the 4.7 to 4
            // assign constant variables -> ERR: The left-hand side of an assignment must be a variable, property or indexer
            // member vars are written in camelNotation and classes and methods in PascalNotation
            const string myConst = "Ben";
            Console.WriteLine(myConst);
            // enums to group related variables
            Console.WriteLine((int)Ages.Steve);
            // tenrary operator
            int x = 12;
            int y = 10;
            int z = y > x ? x > 12 ? z = 12 : z = 4 : z = 40;
            Console.WriteLine(z);
        }
    }
}

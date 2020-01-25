using System;

namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;

            System.Console.Write("Enter your name (firstname lastname)\t:");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();

            System.Console.WriteLine("Hello" + " " + firstname + " " + lastname + "!!!\n" + "Welcome to OOP environment");

            System.Console.ReadKey();
        }
    }
}

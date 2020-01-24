using System;


namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String fname, lname;

            Console.WriteLine("Enter your name (firstname, lastname)");
            fname = Console.ReadLine();
            lname = Console.ReadLine();

            Console.WriteLine("Hello" + " " + fname + " " + lname + "!!!\n" + "Welcome to OOP Environment");
            Console.ReadKey();
        }
    }
}

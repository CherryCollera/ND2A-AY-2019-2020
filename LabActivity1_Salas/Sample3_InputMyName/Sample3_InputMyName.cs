using System;


namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String fname, lname;
            
            System.Console.Write("Enter Your Name (firstname lastname): ");
            fname = Console.ReadLine();
            lname = Console.ReadLine();

            System.Console.WriteLine("Hello" + " " + fname + " " + lname + "!!!\n" + "Welcome to OOP environment");

            System.Console.ReadKey();
        }
    }
}

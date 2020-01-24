using System;


namespace sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            string firstname,lastname;
   
            System.Console.Write("Enter Your Name(Firstname Lasename)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            System.Console.WriteLine("Hello!" + firstname + lastname);
            System.Console.WriteLine("Welcome to OOP Environment");
            System.Console.ReadKey();
        }
    }
}
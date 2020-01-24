using System;


namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            Console.Write("Enter your name(firstname lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello "+firstname+lastname+"!!!\nWelcome to OOP environment.");
            Console.ReadKey();

        }
    }
}

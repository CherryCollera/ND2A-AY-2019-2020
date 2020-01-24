using System;


namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            Console.WriteLine("Enter your Name(firstname, lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();

            Console.WriteLine("Hello" + "" + firstname + "" + lastname + "!!!\n" + "Welcome to OOP environment"); 
            Console.ReadKey();
        }
    }
}

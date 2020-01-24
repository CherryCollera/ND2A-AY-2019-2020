/*18-01163
 John Jeremie Z. Desipida
 BSCS ND2A1
 January 25, 2020
 This program will Input and display my name
 */

using System;


namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String Firstname, Lastname;
            System.Console.Write("Enter Your Name(Firstname Lastname)");
            Firstname = Console.ReadLine();
            Lastname = Console.ReadLine();

            System.Console.WriteLine("Hello"+" "+ Firstname +" "+ Lastname +"!!!");
            System.Console.WriteLine("Welcome to OOP Environment");
            System.Console.ReadKey();
        }
    }
}

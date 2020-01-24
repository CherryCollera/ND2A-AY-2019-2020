using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            System.Console.Write("Enter your Name(firstname lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();

            System.Console.WriteLine("Hello" + " " + firstname + " " + lastname+ "!!!" );
            System.Console.WriteLine("Welcome to OOP environment. ");
            System.Console.ReadKey();
        }
    }
}

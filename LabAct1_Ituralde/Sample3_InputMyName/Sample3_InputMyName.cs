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
            string firstname, lastname;
            Console.Write("Enter Your Name (Firstname Lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello " + firstname+lastname);
            Console.WriteLine("Welcome to OOP environment");
            Console.ReadKey();
        }
    }
}

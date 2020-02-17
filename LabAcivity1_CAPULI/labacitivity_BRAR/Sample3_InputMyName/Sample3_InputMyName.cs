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
            Console.Write("Enter your name(firstname lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello "+firstname+" "+lastname+"!!!\nWelcome to OOP Environment");
            Console.ReadKey();
        }
    }
}

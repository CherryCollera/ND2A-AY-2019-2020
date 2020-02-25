using System;
using ClassExample1_Miller;

namespace ClassExample1_Miller
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            Console.Write("Enter your firstname and lastname");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {

            string name;
            char gender;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Gender M/F: ");
            gender = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'M': case 'm':
                    Console.WriteLine("\nHi " + name +   "  !" + "Your Gender is Male!");
                    break;
                case 'F': case 'f':
                    Console.WriteLine("\nHi " + name +   "  !" + "Your Gender is Female!");
                    break;
                default:
                    Console.WriteLine("\nInvalid input... try again...");
                    break;

                   


            }
            Console.ReadKey();
        }
    }
}

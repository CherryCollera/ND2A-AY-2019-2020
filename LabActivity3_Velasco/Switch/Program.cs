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
            String name;
            Char gender;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Your Gende (M/F): ");
            gender = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'M':
                case 'm':
                    Console.WriteLine("\nHi " + name + "!" + " Your Gender is Male!."); break;
                case 'F':
                case 'f':
                    Console.WriteLine("\nHi " + name + "!" + " Your Gender is Female!."); break;
                default:
                    Console.WriteLine("\nInvalid Input... Try Again..."); break;
            }
        }
    }
}

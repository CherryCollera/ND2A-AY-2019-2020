using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumber
{
    class CompareNumber
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Enter First Number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x > y & x > z)
            {
                Console.WriteLine(x + " Is Greater Than " + y + " And " + z);

                if (y < z)
                {
                    Console.WriteLine(y + " Is Less than " + x);
                    Console.WriteLine(z + " Is Less than " + x);
                }
                else if (y > z)
                {
                    Console.WriteLine(y + " Is Less Than " + x);
                    Console.WriteLine(z + " Is Less than " + x);

                }
                else
                {
                    Console.WriteLine("{0} and {1} aAre Equal", y, z);
                }
                Console.ReadKey();
            }
            if (y > x & y > z)
            {
                Console.WriteLine(x + " Is Greater Than " + y + " And " + z);

                if (x < z)
                {
                    Console.WriteLine(x + " Is Less than " + y);
                    Console.WriteLine(z + " Is Less Than " + y);
                }
                else if (x > z)
                { 
                    Console.WriteLine(z + " Is Less Than " + y);
                    Console.WriteLine(x + " Is Less Than " + y);
                }
                Console.ReadKey();
            }

            if (z > y & z > x)
            {
                Console.WriteLine(z + " Is Greater Than " + y + " And " + x);

                if (y > x)
                {
                    Console.WriteLine(x + " Is Less than " + z);
                    Console.WriteLine(y + " Is Less Than " + z);
                }
                else
                { 
                    Console.WriteLine(y + " Is Less Than " + z);
                    Console.WriteLine(x + " Is Less Than " + z);
                }
                    Console.ReadKey();
            }
            if (x == y && x == y && y == z)
            {
                Console.WriteLine(x + " , " + y + " And " + z + "  Are Equals ");
                Console.ReadKey();
            }
            else
            Console.WriteLine("Invalid Input Please Try Again!");
        }
    }
}

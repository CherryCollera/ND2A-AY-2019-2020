using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumbers
{
    class CompareNumbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {

                Console.WriteLine(num1 + " is Greater Than " + num2 + " and " + num3);

                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is Less Than " + num1);
                    Console.WriteLine(num3 + " is Less Than " + num1);
                }
                else
                    Console.WriteLine(num3 + " is Less Than " + num2);

            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(num2 + " is Greater Than " + num1 + " and " + num3);

                if (num2 > num1)
                {
                    Console.WriteLine(num1 + " is Less Than " + num2);

                }
                else
                    Console.WriteLine(num1 + " is Less Than" + num2);

                if (num2 > num3)
                {
                    Console.WriteLine(num3 + " is Less Than " + num2);
                }
                else
                    Console.WriteLine(num1 + " is Less Than" + num2);



            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine(num3 + " is Greater Than" + num1 + " and " + num2);

                if (num1 > num2)
                {
                    Console.WriteLine(num1 + " is Less Than " + num3);
                    Console.WriteLine(num2 + " is Less Than " + num3);
                }
                else
                    Console.WriteLine(num2 + " is Less Than " + num3);
                }
            else if ((num3 == num1) && (num3 == num2))
                Console.WriteLine( num3 +" "+ num1 + " and " + num2 + " are Equal");
            Console.ReadKey();






                }
     
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class GradingSystem
    {
        static void Main(string[] args)
        {

            double grade;
            String Sgrade;


            Console.Write("Enter your Final Grade   :");
            Sgrade = Console.ReadLine();


            try
            {
                if (Sgrade.Equals("inc") || Sgrade.Equals("INC"))
                {
                    Console.WriteLine("Grade Equivalent : INC\nRemarks: Incomplete");
                }
                else
                {
                    grade = Convert.ToDouble(Sgrade);
                    grade = Math.Round(grade, MidpointRounding.AwayFromZero);

                    if ((grade >= 98) && (grade <= 100))
                    {
                        Console.WriteLine("Grade Equivalent : 1.00\nRemarks: Excellent");

                    }

                    else if ((grade >= 95) && (grade <= 97))
                    {
                        Console.WriteLine("Grade Equivalent : 1.25\nRemarks: Very Good");
                    }
                    else if ((grade >= 92) && (grade <= 94))
                    {
                        Console.WriteLine("Grade Equivalent : 1.50\nRemarks: Very Good");
                    }
                    else if ((grade >= 89) && (grade <= 91))
                    {
                        Console.WriteLine("Grade Equivalent : 1.75\nRemarks:  Very Good");
                    }

                    else if ((grade >= 86) && (grade <= 88))
                    {
                        Console.WriteLine("Grade Equivalent : 2.00\nRemarks: Good");
                    }

                    else if ((grade >= 83) && (grade <= 85))
                    {
                        Console.WriteLine("Grade Equivalent : 2.20\nRemarks: Good");
                    }
                    else if ((grade >= 80) && (grade <= 82))
                    {
                        Console.WriteLine("Grade Equivalent : 2.50\nRemarks: Fair");
                    }
                    else if ((grade >= 77) && (grade <= 79))
                    {
                        Console.WriteLine("Grade Equivalent : 2.75\nRemarks: Fair");
                    }
                    else if ((grade >= 75) && (grade <= 76))
                    {
                        Console.WriteLine("Grade Equivalent : 3.00\nRemarks: Passed");
                    }
                    else if ((grade >= 72) && (grade <= 74))
                    {
                        Console.WriteLine("Grade Equivalent : 4.00\nRemarks: Conditional(MT ONLY)");
                    }
                    else if ((grade >= 60) && (grade <= 71))
                    {
                        Console.WriteLine("Grade Equivalent : 5.00\nRemarks: Failed");
                    }
                }
            }

            catch
            {
                Console.WriteLine("INVALID");
            }

            Console.ReadKey();
        }
    }
}

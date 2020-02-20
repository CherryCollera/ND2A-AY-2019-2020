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
            Double x;
            String Inco;

            Console.Write("Enter Your Final Grade: ");
            Inco = Console.ReadLine();
            try
            {
                if (Inco.Equals("INC") || Inco.Equals("inc"))
                {
                    Console.WriteLine("Grade Equivalent : INCOMPLETE");
                    Console.WriteLine("Remarks : INCOMPLETE");
                    Console.ReadKey();
                }
                else
                {
                    x = Convert.ToDouble(Inco);
                    if ((x >= 97.50) && (x <= 100.00))
                    {
                        Console.WriteLine("Grade Equivalent : 1.00");
                        Console.WriteLine("Remarks : Excellent");
                        Console.ReadKey();
                    }
                    if ((x >= 94.50) && (x <= 97.00))
                    {
                        Console.WriteLine("Grade Equivalent : 1.25");
                        Console.WriteLine("Remarks : Very Good");
                        Console.ReadKey();
                    }
                    if ((x >= 91.50) && (x <= 94.00))
                    {
                        Console.WriteLine("Grade Equivalent : 1.50");
                        Console.WriteLine("Remarks : Very Good");
                        Console.ReadKey();
                    }
                    if ((x >= 88.50) && (x <= 91))
                    {
                        Console.WriteLine("Grade Equivalent : 1.75");
                        Console.WriteLine("Remarks : Very Good");
                        Console.ReadKey();
                    }
                    if ((x >= 85.50) && (x <= 88))
                    {
                        Console.WriteLine("Grade Equivalent : 2.00");
                        Console.WriteLine("Remarks : Good");
                        Console.ReadKey();
                    }
                    if ((x >= 82.50) && (x <= 85))
                    {
                        Console.WriteLine("Grade Equivalent : 2.25");
                        Console.WriteLine("Remarks : Good");
                        Console.ReadKey();
                    }
                    if ((x >= 89.50) && (x <= 82))
                    {
                        Console.WriteLine("Grade Equivalent : 2.50");
                        Console.WriteLine("Remarks : Fair");
                        Console.ReadKey();
                    }
                    if ((x >= 76.50) && (x <= 79))
                    {
                        Console.WriteLine("Grade Equivalent : 2.75");
                        Console.WriteLine("Remarks : Passed");
                        Console.ReadKey();
                    }
                    if ((x >= 74.50) && (x <= 76))
                    {
                        Console.WriteLine("Grade Equivalent : 3.00");
                        Console.WriteLine("Remarks : Passed");
                        Console.ReadKey();
                    }
                    if ((x >= 71.50) && (x <= 74))
                    {
                        Console.WriteLine("Grade Equivalent : 4.00");
                        Console.WriteLine("Remarks : Conditional (MT Only)");
                        Console.ReadKey();
                    }
                    if ((x >= 60) && (x <= 71))
                    {
                        Console.WriteLine("Grade Equivalent : 5.00");
                        Console.WriteLine("Remarks : Failed");
                        Console.ReadKey();
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Format");
                Console.ReadKey();
            }
        }
    }
}

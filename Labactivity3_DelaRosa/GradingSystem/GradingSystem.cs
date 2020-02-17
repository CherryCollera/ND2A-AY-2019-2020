using System;

namespace GradingSystem
{
    class GradingSystem
    {
        static void Main(string[] args)
        {
            Double x;
            String Inco;

            Console.Write("Enter Your Final Grades:");
            Inco = Console.ReadLine();

            try
            {
                if (Inco.Equals("INC") || Inco.Equals("inc"))
                {
                    Console.WriteLine("Grade Equivalent     :   INCOMPLETE");
                    Console.WriteLine("Remarks\t\t     :   INCOMPLETE");
                }
                else
                {
                    x = Convert.ToDouble(Inco);
                    if (x >= 97.50 && x <= 100.00)
                    {
                        Console.WriteLine("Grade Equivalent to       : 1.0");
                        Console.WriteLine("Remarks      : Excellent");
                        Console.ReadKey();
                    }


                    if (x >= 94.50 && x <= 97.49)
                    {
                        Console.WriteLine("Grade Equivalent to: 1.25");
                        Console.WriteLine("Remarks: Excellent");
                        Console.ReadKey();
                    }


                    if (x >= 91.50 && x <= 94)
                    {
                        Console.WriteLine("Grade Equivalent to: 1.50");
                        Console.WriteLine("Remarks: Very Good");
                        Console.ReadKey();
                    }


                    if (x >= 88.50 && x <= 91)
                    {
                        Console.WriteLine("Grade Equivalent to: 1.75");
                        Console.WriteLine("Remarks: Very Good");
                        Console.ReadKey();
                    }


                    if (x >= 85.50 && x <= 88)
                    {
                        Console.WriteLine("Grade Equivalent to: 2.00");
                        Console.WriteLine("Remarks:Good");
                        Console.ReadKey();
                    }


                    if (x >= 79.50 && x <= 85)
                    {
                        Console.WriteLine("Grade Equivalent to: 2.50");
                        Console.WriteLine("Remarks: Fair");
                        Console.ReadKey();
                    }


                    if (x >= 76.50 && x <= 79)
                    {
                        Console.WriteLine("Grade Equivalent to: 2.75");
                        Console.WriteLine("Remarks: Fair");
                        Console.ReadKey();
                    }


                    if (x >= 74.50 && x <= 76)
                    {
                        Console.WriteLine("Grade Equivalent to: 3.0");
                        Console.WriteLine("Remarks: Passed");
                        Console.ReadKey();
                    }


                    if (x >= 72.00 && x <= 74.49)
                    {
                        Console.WriteLine("Grade Equivalent to: 4.00");
                        Console.WriteLine("Remarks: Conditional (Mt only)");
                        Console.ReadKey();
                    }


                    if (x >= 60 && x <= 70)
                    {
                        Console.WriteLine("Grade Equivalent to: 5.00");
                        Console.WriteLine("Remarks: failed");
                        Console.ReadKey();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadKey();
        }
    }
}

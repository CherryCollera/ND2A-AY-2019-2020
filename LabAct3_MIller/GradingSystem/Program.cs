using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            String word1;
            double grade1;
            try
            {
                Console.Write("Enter your final grade: ");
                word1 = Console.ReadLine();
                if (word1.Equals("INC") || word1.Equals("inc"))
                    Console.Write("Grade Equivalent\t:Incomplete\nRemarks\t:Incomplete");
                else
                {
                    grade1 = Convert.ToDouble(word1);
                    if (grade1 >= 97.5)
                        Console.Write("Grade Equivalent\t:1.00\nRemarks\t:Excellent");
                    else if (grade1 >= 94.5)
                        Console.Write("Grade Equivalent\t:1.25\nRemarks\t:Excellent");
                    else if (grade1 >= 91.5)
                        Console.Write("Grade Equivalent\t:1.50\nRemarks\t:Very Good");
                    else if (grade1 >= 88.5)
                        Console.Write("Grade Equivalent\t:1.75\nRemarks\t:Very Good");
                    else if (grade1 >= 85.5)
                        Console.Write("Grade Equivalent\t:2.00\nRemarks\t:Good");
                    else if (grade1 >= 82.5)
                        Console.Write("Grade Equivalent\t:2.25\nRemarks\t:Good");
                    else if (grade1 >= 79.5)
                        Console.Write("Grade Equivalent\t:2.50\nRemarks\t:Fair");
                    else if (grade1 >= 76.5)
                        Console.Write("Grade Equivalent\t:2.75\nRemarks\t:Passed");
                    else if (grade1 >= 74.5)
                        Console.Write("Grade Equivalent\t:3.00\nRemarks\t:Passed");
                    else if (grade1 >= 71.5)
                        Console.Write("Grade Equivalent\t:4.00\nRemarks\t:Conditional (MT Only)");
                    else if (grade1 >= 60)
                        Console.Write("Grade Equivalent\t:5.00\nRemarks\t:Failed");
                    else
                        Console.Write("Grade Equivalent\t:5.00\nRemarks\t:Failed");
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

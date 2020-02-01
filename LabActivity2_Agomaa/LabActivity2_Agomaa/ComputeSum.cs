using System;


namespace LabActivity2_Agomaa
{
    class ComputeSum
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: \t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: \t");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum= {0}  ", num1 + num2);
            Console.ReadLine();

        }
    }
}

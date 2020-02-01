using System;

namespace LabActivity2_Salas
{
    class ComputeSum
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0}  ", num1 + num2);
            Console.ReadLine();

        }
    }
}

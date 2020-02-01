using System;


namespace IFelse
{
    class Ifelse
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                 Console.WriteLine(num1 + " is Greater than: " + num2);
            else if (num2 > num1)
                Console.WriteLine(num2 + " is Greater than: " + num1);
            else
                Console.WriteLine(num1 + " is equal to " + num1);
                Console.ReadKey();
        }
    }
}

﻿using System;

namespace BasicOperation
{
    class BasicOperation
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = {0} ", num1 + num2);
            Console.WriteLine("Difference = {0} ", num1 - num2);
            Console.WriteLine("Product = {0} ", num1 * num2);
            Console.WriteLine("Quotient = {0} ", num1 / num2);
            Console.WriteLine("Remainder = {0} ", num1 % num2);
            Console.ReadKey();
        }
    }
}
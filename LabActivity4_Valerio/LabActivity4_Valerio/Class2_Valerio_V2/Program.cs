﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Valerio_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            String color1, color2;
            System.Console.Write("Enter Color1:\t");
            color1 = System.Console.ReadLine();
            System.Console.Write("Enter Color2:\t");
            color2 = System.Console.ReadLine();

            Car car;

            car = new Car(color1);
            Console.WriteLine(car.Describe());
            car = new Car(color2);
            Console.WriteLine(car.Describe());


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_MillerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string color1, color2;
            Console.WriteLine("Color of the 1st Car: ");
            color1=Console.ReadLine();
            Car car;
            car = new Car(color1);
            Console.WriteLine(car.Describe());

            Console.WriteLine("\nColor of the 2nd Car: ");
            color2 = Console.ReadLine();
            car = new Car(color2);
            Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}

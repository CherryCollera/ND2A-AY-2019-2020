using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2_Ituralde
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Car("Red");
            System.Console.WriteLine(car.Describe());
            car = new Car("Green");
            System.Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}

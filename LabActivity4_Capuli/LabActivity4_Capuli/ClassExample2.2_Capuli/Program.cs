using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Capuli
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Console.ReadLine();

            Car AcceptDetails;
            AcceptDetails = new Car(a.color1, a.color2);
            Console.WriteLine(AcceptDetails.Describe());


            AcceptDetails = new Car(a.color1, a.color2);
            Console.WriteLine(AcceptDetails.Describe2());

            Console.ReadKey();
        }
    }
}

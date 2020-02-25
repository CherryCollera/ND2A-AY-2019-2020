using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity4_Capuli
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Console.ReadLine();

            Car AcceptDetails;
            AcceptDetails = new Car(a.FColor, a.SColor);
            Console.WriteLine(AcceptDetails.Describe());


            AcceptDetails = new Car(a.FColor, a.SColor);
            Console.WriteLine(AcceptDetails.Describe2());

        }
    }
}

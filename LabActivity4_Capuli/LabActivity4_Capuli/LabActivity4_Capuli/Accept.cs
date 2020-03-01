using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity4_Capuli
{
    class Accept
    {
        public string FColor, SColor;
        public void AcceptDetails()
        {
            System.Console.Write("Enter First Car Color\t");
            FColor = System.Console.ReadLine();
            System.Console.Write("Enter Second Color\t");
            Scolor = System.Console.ReadLine();
        }
    }
}

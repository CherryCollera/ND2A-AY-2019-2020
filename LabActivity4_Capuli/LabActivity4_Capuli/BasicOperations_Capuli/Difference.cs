using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Difference
    {
        public void getDifference()
        {
            DeclareVar.difference = DeclareVar.num1 - DeclareVar.num2;
            Console.WriteLine("Difference : " + DeclareVar.difference);
        }
    }
}

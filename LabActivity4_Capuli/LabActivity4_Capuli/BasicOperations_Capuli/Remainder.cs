using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Remainder
    {
        public void getRemainder()
        {
            DeclareVar.remainder = DeclareVar.num1 % DeclareVar.num2;
            Console.WriteLine("Remainder : " + DeclareVar.remainder);
        }
    }
}

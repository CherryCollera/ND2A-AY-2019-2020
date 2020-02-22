using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Desipida
{
    class Program

    {static void Main (String[] Args)
        {
           
            Input inp = new Input(); 
            inp.number();
            Sum s = new Sum();
            Difference d = new Difference();
            Product p = new Product();
            Quotient q = new Quotient();
            Remainder r = new Remainder();
          

            s.GetSum();
            d.GetDifference();
            p.GetProduct();
            q.GetQuotient();
            r.GetRemainder();

            Console.WriteLine("\nSum:\t\t\t " + DeclareVar.Sum);
            Console.WriteLine("Difference:\t\t " + DeclareVar.Difference);
            Console.WriteLine("Product:\t\t " + DeclareVar.Product);
            Console.WriteLine("Qoutient:\t\t " + DeclareVar.Quotient);
           Console.WriteLine("Remainder:\t\t " + DeclareVar.Remainder);

            Console.ReadLine();
        }

    }
    
}


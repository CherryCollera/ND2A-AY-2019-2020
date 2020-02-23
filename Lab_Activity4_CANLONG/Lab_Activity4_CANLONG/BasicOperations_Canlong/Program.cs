using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicOperations_Canlong
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int a, b;
                Input inp = new Input();
                Sum s = new Sum();
               
                Difference d = new Difference();
                Product p = new Product();
                Quotient q = new Quotient();
                Remainder r = new Remainder();
                 inp.number();

           
               s.GetSum();
               d.GetDifference();
               p.GetProduct();
               q.GetQuotient();
               r.GetRemainder();


                Console.WriteLine("\nSUM:\t\t" + DeclareVar.Sum);
                Console.WriteLine("\nDIFFERENCE:\t\t" +DeclareVar.Difference);
                Console.WriteLine("\nPRODUCT:\t\t" + DeclareVar.Product);
                Console.WriteLine("\nQUOTIENT:\t\t" + DeclareVar.Quotient);
                Console.WriteLine("\nREMAINDER:\t\t" + DeclareVar.Remainder);

                Console.ReadLine();
         
        }
    }
}

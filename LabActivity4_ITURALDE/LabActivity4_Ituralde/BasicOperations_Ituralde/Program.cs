using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Ituralde
{
    class Program
    {
        static void Main(string[] args)
        {
            Input inp = new Input();
            inp.numb1();
            Sum s = new Sum();
            s.getSum();
            Difference d = new Difference();
            d.getDifference();
            Product p = new Product();
            p.getProduct();
            Quotient q = new Quotient();
            q.getQuotient();
            Remainder r = new Remainder();
            r.getRemainder();


            Console.WriteLine(" Sum : " + declare.sum);
            Console.WriteLine("Difference : " + declare.difference);
            Console.WriteLine("Product : " + declare.product);
            Console.WriteLine("Quotient : " + declare.quotient);
            Console.WriteLine("Remainder : " + declare.remainder);
            Console.ReadKey();
        }
    }
}

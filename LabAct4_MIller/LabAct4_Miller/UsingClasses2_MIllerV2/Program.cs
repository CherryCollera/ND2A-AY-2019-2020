using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses2_MIllerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Input.SetInput();
            Sum s = new Sum();
            Difference d = new Difference();
            Product p = new Product();
            Quotient q = new Quotient();
            Remainder r = new Remainder();
            s.getSum();
            d.getDiff();
            p.getProd();
            q.getQuot();
            r.getRem();

            Console.WriteLine("\nSum\t\t:\t" + DeclareVar.sum);
            Console.WriteLine("Difference\t:\t" + DeclareVar.difference);
            Console.WriteLine("Product\t\t:\t" + DeclareVar.product);
            Console.WriteLine("Quotient\t:\t" + DeclareVar.quotient);
            Console.WriteLine("Remainder\t:\t" + DeclareVar.remainder);
            Console.ReadKey();
        }
    }
}

using System;


namespace BasicOperations_Delarosa
{
    class Program
    {
        public static void Main(string[] args)
        {
            Declarevar dv = new Declarevar();
            dv.Declaringvar();
            


            Sum s = new Sum();
            Difference d = new Difference();
            Product p = new Product();
            Quotient t = new Quotient();
            Remainder r = new Remainder();
            Input ip = new Input();

            ip.getInput();
            s.AcceptSum();
            d.getDifference();
            p.getProduct();
            t.getQuotient();
            r.getRemainder();
            

            System.Console.WriteLine("Sum\t\t:\t\t " + Declarevar.Sum);
            System.Console.WriteLine("Difference\t:\t\t " + Declarevar.Difference);
            System.Console.WriteLine("Product\t\t:\t\t " + Declarevar.Product);
            System.Console.WriteLine("Quotient\t:\t\t " + Declarevar.Quotient);
            System.Console.WriteLine("Remainder\t:\t\t " + Declarevar.Remainder);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNames
{
    class CompareNames
    {
        static void Main(string[] args)
        {
            string string1 = "JHAYJHAY";
            string string2 = "JHAYJHAY";
            string string3 = "Jhay";
            string string4 = "jhay";
            string string5 = "jhayjhay";


            Console.WriteLine("Using Equals() Method");

            Console.WriteLine("     compare {0} to  {1}: {2}", string1, string2, string.Equals(string1, string2));
            Console.WriteLine("     compare {0} to  {1}: {2}", string1, string3, string.Equals(string1, string3));
            Console.WriteLine("Lenght of {0} is  {1}", string1, string1.Length);
            Console.WriteLine("String {0} Substring(0,3) will return {1}", string5, string5.Substring(0,3));


            Console.WriteLine("Using Compare() Method");
            Console.WriteLine("     compare {0} to {1}: {2}",string1, string2, string.Compare(string1, string2));
            Console.WriteLine("     compare {0} to {1}: {2}", string1, string3, string.Compare(string1, string3));
            Console.WriteLine("     compare {0} to {1}: {2}", string3, string1, string.Compare(string3, string1));
            Console.WriteLine("     compare {0} to {1}: {2}", string4, string5, string.Compare(string4, string5));

            Console.WriteLine("Using Compare() Method");
            Console.WriteLine("     compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine("     compare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
            Console.WriteLine("     compare {0} to {1}: {2}", string3, string1, string3.CompareTo(string1));

            Console.ReadKey();

        }
    }
}

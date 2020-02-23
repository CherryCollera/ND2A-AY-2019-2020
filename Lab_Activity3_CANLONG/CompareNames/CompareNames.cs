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
            string string1 = "Cathy";
            string string2 = "Cathy";
            string string3 = "Catherine";
            string string4 = "catherine";
            string string5 = "CATHERINE";

            Console.WriteLine("Using Equals() method");
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string2, string.Equals(string1, string2));
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string2, string.Equals(string1, string3));
            Console.WriteLine("\nLength of {0} is {1}", string1, string1.Length);
            Console.WriteLine("String {0} Substring (0, 3) will return {1}", string5, string5.Substring(0,3));

            Console.WriteLine("\nUsing Compare() method");
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string2, string.Compare(string1, string2));
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string3, string.Compare(string1, string3));
            Console.WriteLine("    compare {0} to {1}: {2}", string3, string1, string.Compare(string3, string1));
            Console.WriteLine("    compare {0} to {1}: {2}", string4, string5, string.Equals(string4, string5));

            Console.WriteLine("\nUsing CompareTo() method");
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string2, string.Compare(string1, string2));
            Console.WriteLine("    compare {0} to {1}: {2}", string1, string3, string.Compare(string1, string3));
            Console.WriteLine("    compare {0} to {1}: {2}", string3, string1, string.Compare(string3, string1));

            Console.ReadKey();
        }
    }
}

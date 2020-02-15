using System;

namespace CompareNames
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1= "tine";
            String s2= "tine";
            String s3= "justine";
            String s4 = "Justine";
            String s5 = "JUSTINE";

            Console.WriteLine("Using Equals() method");

            Console.WriteLine("     compare {0} to {1}: {2}",s1,s2,string.Equals(s1,s2));
            Console.WriteLine("     compare {0} to {1}: {2}", s1, s3, string.Equals(s1, s3));
            Console.WriteLine("     Length of {0} is {1}", s1, s1.Length);
            Console.WriteLine("     String {0} Substring (0,3) will return {1}", s5, s5.Substring(0,3));

            Console.WriteLine("Using Compare() method");
            Console.WriteLine("     compare {0} to {1}: {2}", s1, s2, string.Compare(s1, s2));
            Console.WriteLine("     compare {0} to {1}: {2}", s1, s3, string.Compare(s1, s3));
            Console.WriteLine("     compare {0} to {1}: {2}", s3, s1, string.Compare(s3, s1));
            Console.WriteLine("     compare {0} to {1}: {2}", s4, s5, string.Equals(s4, s5));

            Console.WriteLine("Using CompareTo() method");
            Console.WriteLine("     compare {0} to {1}: {2}", s1, s2, s1.CompareTo(s2));
            Console.WriteLine("     compare {0} to {1}: {2}", s1, s3, s1.CompareTo(s3));
            Console.WriteLine("     compare {0} to {1}: {2}", s3, s1, s3.CompareTo(s1));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            compairString();
            Console.WriteLine();
            concatestring();
            Console.WriteLine();
            concateArrayString();   
            Console.WriteLine();
            stringEnd();
            Console.WriteLine();
            Console.WriteLine(reverseUpper("welcome"));
            //reverseUpper("welcome");
            Console.WriteLine();
            Console.WriteLine(UpperLower("JaVaScrIPt"));



        }

        public static void compairString()
        {
            string s1 = "WELCOME";
            string s2 = "welcome";

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            Console.WriteLine("The Strings are equal when capitalized?  : {0}",
                          String.Compare(s1.ToUpper(), s2.ToUpper()) == 0
                                         ? "true" : "false");


            Console.WriteLine("The Strings are equal when case is ignored? : {0}",
                        String.Compare(s1, s2, true) == 0
                                       ? "true" : "false");

        }


        public static void concatestring()
        {
            string s1 = "Hello ";
            string s2 = "Wel ";
            string s3 = "Come ";


            Console.WriteLine(String.Concat(s1 , s2 , s3));
        }

        public static void concateArrayString()
        {
            string[] s1 = { "apple ", "cat ", "dog ", "ant ", "earth ", "plant " };


            Console.WriteLine(String.Concat(s1));

            Console.WriteLine();
            Array.Sort(s1);


            Console.WriteLine(String.Concat(s1));
        }


        public static void stringEnd()
        {
            string[] s = { "java.", "python", "html.", "css", "php.", "javascript" };


            foreach(var value in s)
            {
                bool end = value.EndsWith(".");

                Console.WriteLine("{0} end with '.' : {1} ", value, end);
            }

        }


        public static string reverseUpper(string s)
        {
            //string s = "welcome";

            Console.WriteLine("Reverse and uppercase");
            Console.WriteLine(s);

            return new string(s.ToCharArray().Reverse().ToArray()).ToUpper();
        }


        public static string UpperLower(string s)
        {
            //string s = "JaVaScrIPt";

            Console.WriteLine("Upper to lower and lower to upper");
            Console.WriteLine(s);


            return string.Concat(s.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));


        }
    }
}
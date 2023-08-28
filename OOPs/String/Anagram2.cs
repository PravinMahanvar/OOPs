using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Anagram2
    {
        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "pilent";

            char[] ch1 = str1.ToLower().ToCharArray();
            Char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string str3 = new string(ch1);
            string str4 = new string(ch2);
            Console.WriteLine("given to string is:");

            if (str3 == str4)
            {
                Console.WriteLine("Anagram");

            }
            else
            {
                Console.WriteLine(" not Anagram");
            }

        }
    }
}

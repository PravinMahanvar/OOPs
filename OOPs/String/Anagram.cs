using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{

  //  16.	Write a C# program to check whether two strings are anagram or not?
    internal class Anagram
    {
        static void Main(string[] args)
        {
            string sms1 = "listen";
            string sms2 = "silent";
            bool same = true;
            sms1.ToLower();
            sms2.ToLower();
            char[]ch1 = sms1.ToCharArray();
            char[]ch2 = sms2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string c1=new string(ch1);
            string c2=new string(ch2);
            Console.WriteLine( ch1);
            Console.WriteLine(ch2);
            if (sms1.Length != sms2.Length)
            {
                same= false;

            }
            for (int i = 0, j = 0; i < ch1.Length || j < ch2.Length; i++, j++)
            {
                if (ch1[i] != ch2[j])
                {
                    same= false;
                }
            }
            if (same)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }
        }
        
    }
}

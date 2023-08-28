using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{

    // 12.	Write a C# program to find highest frequency character in a string.
    internal class Findhighest
    {
        static void Main(string[] args)
        {
            string str1 = "hello world";
            int[] charcount = new int[256];
            char[] ch = str1.ToCharArray();

            for(int i= 0; i<str1.Length; i++)
            {
                char ch1= str1[i];
                charcount[ch1]++;
            }

            int maxcount = 0;
            char maxchar = ch[0];

            for(int i =0; i<256; i++)
            {
                if (charcount[i] > maxcount)
                {
                    maxcount = charcount[i];
                    maxchar = ch[i];
                }
            }
            Console.WriteLine("the highest frq char is" + maxchar);
        }
    }
}

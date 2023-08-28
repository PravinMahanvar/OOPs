using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Reverseofworld
    {
        //11.	Write a C# program to reverse order of words in a given string.(I love india)

        static void Main(string[] args)
        {
            string s = "I evol aidni";
            string str = "";
            string[] st = s.Split(' ');

            for(int i =0; i < st.Length; i++)
            {
                string word= st[i];
                string rev = "";

                for(int j=word.Length-1; j >= 0; j--)
                {
                    rev= rev+ word[j];
                }
                str = str + " " + rev;
            }
            Console.WriteLine(str);

        }
    }
}

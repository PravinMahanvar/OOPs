using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Count

    //Write a C# program to count total number of vowels and consonants in a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hiii good morning ");

            string str= Convert.ToString(Console.ReadLine());

            int vowelscount = 0;
            int consonantcount = 0;

            foreach(char  c in str)
            {
                if(c == 'a' || c == 'A' || c == 'e' || c== 'E'|| c=='I' ||c=='i'|| c=='o'|| c=='O'||c=='U'|| c == 'u')
                {
                    vowelscount++;
                }
                else
                {
                    consonantcount++;
                }
            }
            Console.WriteLine($"total number of vowel:{vowelscount}");
            Console.WriteLine($"total number of consonantcount:{consonantcount}");

        }
    }
}

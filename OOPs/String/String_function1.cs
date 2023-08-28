using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class String_function1
    {
        static void Main(string[] args)
        {

            string message = "Hello to all";
            string message2 = "hello to all";
            // Method of string class
            string str1 = string.Concat(message, "", message2.TrimEnd());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine("index - " + message2.IndexOf("o"));
            Console.WriteLine("last index " + message2.LastIndexOf("o"));

            //convert string to string array

            string[] straa = message2.Split(',');
            //Convert string to char array
            char[] ch = message.ToCharArray();

            //Convert char array to astring 
            string str2 = new string(ch);
            Console.WriteLine(str2);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(straa[0]);//Good
            Console.WriteLine(straa[1]);//morning 

            foreach (string s in straa)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }

        }
    }
}

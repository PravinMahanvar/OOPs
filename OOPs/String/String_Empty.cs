using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class String_Empty
    {
        static void Main(string[] args)
        {
            string str = "";
            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string is empty");
            }
            Console.WriteLine(str);
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty (name))
            {
                Console.WriteLine("name is required");

            }
            else
            {
                Console.WriteLine("Hello" + " " + name);
            }
        }
    }
}

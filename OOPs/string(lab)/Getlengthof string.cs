using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.string_lab_
{

    // length of string?
    internal class Getlengthof_string
    {
        static void Main(string[] args)
        {
            string name  = "Pravin Mahanvar ";
            Console.WriteLine("name" + name);
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.IndexOf('M'));
            Console.WriteLine(name.IndexOf('v'));
            Console.WriteLine(name.IndexOf('r'));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.LastIndexOf('n'));
            Console.WriteLine(name.Equals("pravin mahanvar"));
        }

    }
}

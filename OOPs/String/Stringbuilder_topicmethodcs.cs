using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Stringbuilder_topicmethodcs
    {
        static void Main(string[] args)
        {
            StringBuilder strbuilder = new StringBuilder("hello to all");
            Console.WriteLine(strbuilder);

            strbuilder.Append("Good Morning");
            Console.WriteLine(strbuilder);

            strbuilder.Remove(4, 5);
            Console.WriteLine(strbuilder);

            strbuilder.Replace('l', 'L');
            Console.WriteLine(strbuilder);

            strbuilder.Replace("all", "everyone");
            Console.WriteLine(strbuilder);
            Console.WriteLine("Capacity=" + strbuilder.Capacity);
            strbuilder.Clear();
            Console.WriteLine(strbuilder);
        }
    }
}

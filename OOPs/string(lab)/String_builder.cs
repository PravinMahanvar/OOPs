using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.string_lab_
{
    internal class String_builder
    {
        static void Main(string[] args)
        {
            string sms = "hello to all";
            Console.WriteLine(sms);
            Console.WriteLine(sms.GetHashCode());

            sms = sms + "good morning";
            Console.WriteLine(sms);
            Console.WriteLine(sms.GetHashCode());
        }
    }
}

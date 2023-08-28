using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Hashtable_2
    {
        static void Main(string[] args)
        {
            Hashtable p = new Hashtable();
            p.Add(91, "india");
            p.Add(0, "pakistan");
            p.Add(1, "USA");
            p.Add(52, "japan");

            foreach (DictionaryEntry item in p) 
            {
                Console.WriteLine($"{item.Key} {item.Value}");
                
                
                
            }

        }
    }
}

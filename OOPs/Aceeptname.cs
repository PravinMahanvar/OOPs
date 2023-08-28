using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Aceeptname
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            for(int i= 0; i<name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            for(int i =0; i<name.Length;i++)
            {
                Console.WriteLine($"names[{i}]=" + name[i]);
            }
            
        }
    }
}

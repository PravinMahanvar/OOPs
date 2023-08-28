using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public  class Swapcs
    {
        static void Swap25(ref int a,  ref int b)
        {
            int temp;
            temp = a;
            a= b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 200, b = 400;
            Swap25(ref a, ref b);
            Console.WriteLine($"a= {a}, b= {b}");   
        }
    }
}

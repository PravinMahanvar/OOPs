using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_even_odd

    {
        static void Main(string[] args)
        {
            int[] even = new int[10];
            for (int i= 0; i<even.Length; i++)
            {
                even[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("even array");
            for(int i=1; i<even.Length; i++)
            {
                if (even[i]%2 ==0)
                {
                    Console.WriteLine(even[i]);
                }
            }
            Console.WriteLine("odd and even array");
            for(int i=0; i<even.Length; i++)
                if (even[i]%2 != 0)
                {
                    Console.WriteLine(even[i]);
                }
            
        }

    }
}

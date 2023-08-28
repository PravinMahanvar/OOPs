using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_Display_alternative
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 45, 43, 55, 65, 43 };
            for(int i =0; i<array.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}

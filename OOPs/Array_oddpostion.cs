using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_oddpostion
    {
        static void Main(string[] args)
        {
            int[] array  = new int[5];


            for (int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i =0; i < array.Length; i++)
            {
                if(i % 2 !=0)
                {
                    Console.WriteLine("odd the position element is" + array[i]);
                }
            }

        }
    }
}

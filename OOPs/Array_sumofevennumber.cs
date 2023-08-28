using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_sumofevennumber
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 10, 21, 24, 35, 40 };
            int sum = 0;
            for(int i  = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum= sum+ array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

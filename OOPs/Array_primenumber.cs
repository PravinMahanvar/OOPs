using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_primenumber
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i =0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i =0; i<array.Length;i++)
            {
                bool isprime = true;
                for(int j=2; j<array.Length;j++)
                {
                    if (array[i] % j == 0)
                    {
                         isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine("prime no" + array[i]);
                }
                
            }
        }
    }
}

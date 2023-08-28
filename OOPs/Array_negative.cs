using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_negative
    {
        static void Main(string[] args)
        {
            int[] negative = new int[10];
            int count = 0;
            for (int i = 0; i < negative.Length; i++)
            {
                Console.WriteLine("enter the number");
                negative[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < negative.Length; i++)
            {
                if (negative[i] < 0)
                {
                    Console.WriteLine("negative number"+ negative[i]);
                    count++;
                }
            }
            Console.WriteLine("COUNT NUMBER" +count);

        }
    }
}

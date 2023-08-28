using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Negative_21
    {
       //  print all negative elements in an array and also count the total number of negative elements in an array.
        static void Main(string[] args)
        {
            int count = 0;
            int[] num = new int[10];
            for(int i =0; i< num.Length; i++)
            {
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i<num.Length; i++)
            {
                if (num[i] == 0)
                {
                    Console.WriteLine("negative number" + num[i]);
                    count++;
                }
            }
            Console.WriteLine("total negative number are " + count);
        }
    }
}

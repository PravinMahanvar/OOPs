using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_searchthenumber
    {
        static void Main(string[] args)

        { 
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("enter the number to search");
            int p= Convert.ToInt32(Console.ReadLine());

            for(int i =0; i< number.Length; i++)
            {
                if (number[i] == p)
                {
                    Console.WriteLine("number found and index is" + i);

                }

            } 
            
        }
    }
}

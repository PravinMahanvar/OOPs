using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Printeven
    {
        //WAP to declare an array of 10 size, accept the value & print only even numbers.
        static void Main(string[] args)
        {
            int[] number = new int[10];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < number.Length; i++)

            {
                if (number[i] % 2 == 0)
                {
                    Console.WriteLine("even the number" + number[i]);
                }

            }



        }
    }
}
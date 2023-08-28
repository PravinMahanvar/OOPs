using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Rainfall21
    {
        static void Main(string[] args)
        {
            double[] rain = new double[7];
            for(int i= 0; i<rain.Length; i++)
            {
                rain[i] = Convert.ToDouble(Console.ReadLine());

            }
            for(int i= 0; i<rain.Length; i++)
            {
                Console.WriteLine("week rainfall is  " +rain[i]);
            }

        }
    }
}

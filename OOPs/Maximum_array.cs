using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public  class Maximum_array
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for(int i =0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int m = num[0];
            int n= num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > m)
                {
                    m = num[i];
                }
                else if (num[i] > n)
                {
                    num[i] = m;
                }
            }
            Console.WriteLine("maximum number" + m);
            Console.WriteLine("Minmum number" + n);
           
        }
    }
}

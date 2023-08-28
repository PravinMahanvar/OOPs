using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Prime_number
    {
        // 11 to 21 prime number
        static void Main(string[] args)
        {
            
            for (int i= 11; i<=21; i++)
            {
                bool isPrime = true;
                for (int j =2; j<= 21; i++)
                {
                    if(i %j== 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);

                }
            }
            
        }
    }
}

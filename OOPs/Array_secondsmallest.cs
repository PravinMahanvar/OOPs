using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_secondsmallest
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = { 5, 2, 8, 1, 9, 4, 3, 7, 6 };

                int smallest = int.MaxValue;
                int secondSmallest = int.MaxValue;

                foreach (int num in numbers)
                {
                    if (num < smallest)
                    {
                        secondSmallest = smallest;
                        smallest = num;
                    }
                    else if (num < secondSmallest && num != smallest)
                    {
                        secondSmallest = num;
                    }
                }

                Console.WriteLine("Smallest: " + smallest);
                Console.WriteLine("Second Smallest: " + secondSmallest);
            }
        }
    }
}






        
        
        
    


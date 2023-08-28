using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Use_forechloops
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1, 2, 3, 4, 5};
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            int[,] array2 = new int[3, 4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
            };
            foreach (int a in array2)
            {
                Console.WriteLine(a);
            }
            string[] names = new string[5] { "pravin", "pramod", "ravi", "suraj", "pream" };
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
            
            
            
            
            
            
            
            
        }
    }
}

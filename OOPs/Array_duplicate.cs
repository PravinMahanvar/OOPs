using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_duplicate
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 3, 2, 4, 1, 4 };
            

            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (num[k] == num[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                
                if (isvisited == false)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                        }
                    }
                        if (count > 1)
                        {
                                Console.WriteLine(num[i]);
                        }
                    



                }
              // Console.WriteLine("total duplicate number are" + count);
            }
        }
    }
}
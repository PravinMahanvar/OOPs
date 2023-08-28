using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    /*//{11,12,13,14,15}
      {16,17,18,19,20}
      {21,22,23,24,25}
      {26,27,28,29,30}*/
    internal class Array_twodimensionway
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
            for(int i= 0; i<arr.GetLength(0); i++)
            {
                for( int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());


                }
            }
            for(int i= 0; i<arr.GetLength(0); i++)
            {
                for(int j= 0; j<arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]= {arr[i,j]}");
                }
                Console.WriteLine("\n");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_sort
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 1, 20, 14, };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }


            }
            Console.WriteLine("ascding order");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; i < array.Length; i++)
                {
                    if (array[i] == array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            Console.WriteLine("desceding order");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
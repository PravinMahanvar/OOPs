using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_sortsecondway
    {
        // aseding and decding ?
        static void Main(string[] args)
        {
            int[] array = { 10, 1, 20, 14, };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[1];
                        array[1] = array[j];
                        array[j] = temp;
                    }
                }


            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
            Console.WriteLine("aesending order");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            for (int i =0; i < array.Length; i++)
            {
                for(int j=0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp= array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                    
            }
            Console.WriteLine("Desending order");
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            





        }
    }
} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array_searchnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int num = Convert.ToInt32(Console.ReadLine());

            int[]arr = new int[num];
            Console.WriteLine("enter the list");

            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Enter the number want to search");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool isfound = false;
            for(int i = 0; i<arr.Length;i++)
            {
                if (arr[i]== num2)
                {
                    isfound = true;
                    break;
                }
            }
            if (isfound== true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number not present");
            }
            
        }
    }
}

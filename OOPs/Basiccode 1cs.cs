using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public  class Basiccode_1cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int num= Convert.ToInt32(Console.ReadLine());
            {
                for (int i = 0; i <= 50; i++)
                {

                    if (num % 3 == 0)
                    {
                        Console.WriteLine("tq");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine(" the welcome ");
                    }
                    else if (num % 3 == 0 && num % 5 == 0) 
                    {
                        Console.WriteLine("disply welcome to tq");
                    }
                } 
            }
        }
    }
}

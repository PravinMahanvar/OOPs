using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPs.String
{
    internal class Collection_method
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 34, 54, 56, 23, 67 };
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(22);
            list.Add(34);

            list.Insert(1, 3.6);
           /* list.AddRange(arr);
           *//* list.Remove(1.5);
            list.RemoveAt(0);
            list.RemoveRange(2, 3);
            list.Clear();*/

          //  list.Sort();
            list.Reverse();
            Console.WriteLine("count(total element)"+list.Count);
            Console.WriteLine("capacity" + list.Capacity);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }



        }
    }
}

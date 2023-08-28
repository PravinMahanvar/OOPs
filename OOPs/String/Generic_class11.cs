using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Generic_class11
    {
        static void Main(string[] args)
        {
            List<int>List1= new List<int>();

            List1.Add(1);
            List1.Add(2);
            List1.Add(3);
            List1.Add(4);
            List1.Remove(3);
            List1.AddRange(List1);
            List1.Insert(1,2);
          //  List1.Clear();
            Console.WriteLine("Total count "+ List1.Count);
            

            Stack<int> Stack1= new Stack<int>();
            Stack1.Push(1);
            Stack1.Push(2);
            Stack1.Push(3);
            Stack1.Push(4);

            Console.WriteLine("Total count" + Stack1.Count);

            Queue<string>queue= new Queue<string>();
            queue.Enqueue("pune");
            queue.Enqueue("mumbai");
            queue.Dequeue();
           // queue.Clear();

            Console.WriteLine("total count " +queue.Count);

            foreach(int s in List1) 
            {
                Console.WriteLine(" List is "+s);
            }
            foreach(int s in Stack1)
            {
                Console.WriteLine(" list is "+s);
            }
            foreach(string i in queue)
            {
                Console.WriteLine("list is "+i);
            }


            Dictionary<string,string> dictionary= new Dictionary<string,string>();

            dictionary.Add(".docx", "world file");
            dictionary.Add(".xlsx", "Excel file");
            dictionary.Add(".cs", "c#");

            foreach(KeyValuePair<string,string> item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Dictionary<int,string> dictionary2 = new Dictionary<int,string>();

            dictionary2.Add(102, "HR");
            dictionary2.Add(102, "SALES");
            dictionary2.Add(103, "Marketing");
            dictionary2.Remove(102);

            foreach(KeyValuePair<int, string> iteam in dictionary2)
            {
                Console.WriteLine($"{iteam.Key} {iteam.Value}");
            }








        }
    }
}

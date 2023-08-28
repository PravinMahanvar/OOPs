using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Run2
    {
        static void Main(string[] args)
        {
            j_Employee1[] list = new j_Employee1[3]
            {
                new j_Employee1 {Id=1,Name ="pravin", price= 500},
                new j_Employee1{Id=2,Name = "pramod",price = 1000 },
                new j_Employee1{Id =3,Name = "sona",  price = 59 },
            };
            foreach (j_Employee1 p in list)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.price}");
            }
             Console.WriteLine("********");
            book[] list2 = new book[3]
            {
                 new book{Id=1, Name="nani",Author="kele sir", price=500},
                 new book{Id=2, Name ="aangipath",Author= "kalam sir", price=499},
                 new book{Id=3,Name = "aai",Author= "pravin", price= 700},
            };
            foreach(book b in list2)
            {
                Console.WriteLine($"{b.Id} {b.Name} {b.Author} {b.price}");
            }
        }
    }
}

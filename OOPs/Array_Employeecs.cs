using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Array_Employeecs
    {
        int id;
        string name;
        int salary;

        public Array_Employeecs(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{id} {name} {salary}";
        }

        public static void Main(string[] args)
        {
            Array_Employeecs[] emp = new Array_Employeecs[3];
           

            for(int i =0; i< emp.Length; i++)
            {
                Console.WriteLine("enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name");
               string name = Console.ReadLine();
                Console.WriteLine("inter the salary");
                int salary= Convert.ToInt32(Console.ReadLine());

                emp[i] = new Array_Employeecs(id, name, salary);    

               
                    if(salary>4000)
                    {
                        Console.WriteLine(emp[i]);
                    }
                
                
            }

        }
    }

}

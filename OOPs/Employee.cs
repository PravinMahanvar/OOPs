using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary, hra, da, ta, pf, gross;
        private static int count;///  default value
        
        

        // Constutor 

        public Employee() // parameter less constuctor 
        {
            id = 0;
            name = "";
            salary = 0.00;
        }

        public Employee(int id, string name, double salary)// parametric constructor
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
        }
        public static int GetEmpCount()
        {
            return count;
        }

        public void CalculatedSalary()
        {
            hra = salary * 700.09;
            da = salary * 500.09;
            ta = salary * 600.90;
            pf = salary * 800;
            gross = (salary + hra + da + ta) - pf;
         
        }
         public string Print()
        {
            return $"Emp id ={id},  name{name}, basic salary={salary},gross= {gross}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Employee1_ass
    {
        private int id;
        private string name;
        private double salary, hra, ta, pf, gross;

        public Employee1_ass(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    
        public void calculated ()
        {
            hra = salary * 56;
            ta = salary * 89;
            gross = (salary + hra + ta) - pf;

        }
        public string Display()
        {
            return $"{name} {salary} {gross}";
        }



    }
}

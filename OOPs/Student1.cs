using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public  class Student1
    {
        private int rollno;
        private string name, branch;
        private double math, phy, science, percentage, total;

        public Student1()
        {
            rollno = 0;
            name = "";
            branch = "";
            math = 0.0;
            phy = 0.0; science = 0.0;
        
            
                            
        }
        public Student1(int rollno, string name, string branch, double math, double phy, double science, double percentage, double total )
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.math = math;
            this.phy = phy;
            this.science = science;
            this.percentage = percentage;
            this.total = total;
        }
        public void calculatepercentage()
        {
            total = math + phy + science;
            percentage = total / 3;
        }

        public void calculateGrade()
        {
            if
                (percentage>90)
            {
                Console.WriteLine("A grade");
            }
            else if(percentage>50)
            {
                Console.WriteLine("B grade");
            }
            else
            {
                Console.WriteLine("C grade");
            }

        }
           public string PrintStudent1()
        {
            return $"student{rollno}\n {percentage}\n {name}\n {branch}";
        }
    }
}

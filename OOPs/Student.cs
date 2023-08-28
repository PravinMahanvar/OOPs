using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Student
    {
        //Create> rollno,name,percentage,branch,
        private int rollno;
        private double percentage;
        private string name, branch;

        public void AcceptStudent(int p, double r ,string a, string v)
        {
            rollno = p;
            percentage = r;
            name = a;
            branch = v;

        }
        public string PrintStudent()

        {
            return $"Student :{name}/ {rollno}/ {percentage}/{branch}";
        }
        
        

        

        }


        

        }

        
    


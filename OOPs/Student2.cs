using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Student2
    {
        private int rollno;
        private string name;
        private double prcentage;

        // syntax of property>>>>>>>>.. Rollno is a property name 

        public int Rollno
        {
            set { rollno = value; }
            get { return  rollno; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Base21
    {
        protected int rollno;
        protected string name;

        public Base21(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public virtual string Disply()
        {
            return $" roll number ={rollno} name ={name}";
        }
    }
    public class Chil1 : Base21
    {
        public Chil1(int rollno, string name) : base(rollno, name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public override string Disply()
        {
            return base.Disply();
        }
    }



}    

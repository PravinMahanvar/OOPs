using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Inheritance
{
    abstract public class Shape
    {
        public abstract string Draw(string name);
        public abstract void Area();
    }
    public class calculate:Shape
    {
        private int length, bredth;
        int area;

        public override string Draw(string name)
        {
            throw new NotImplementedException();    
        }

        public calculate(int length, int bredth)
        {
            this .length = length;
            this .bredth = bredth;
        }
        public override void Area()
        {
            area = length * bredth;
        }
        public void Displaymethod()
        {
            Console.WriteLine(length + "\t" + bredth + "\nArea of rectangleis :area)");
        }
    }
}

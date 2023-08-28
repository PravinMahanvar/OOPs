using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public  class Base90
    {

        // method overriding method >>>>>>.
        public virtual string Print()
        {
            return " sms from base class here";
        }
    }
    public class childclass: Base90
    {
        public override string Print()
        {
            return " sms from childclass";
        }
        static void Main(string[] args)
        {
            Base90 obj = new childclass();
            Console.WriteLine(obj.Print());
        }

    }
    

}

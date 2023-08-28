using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface
{
    public  interface IPritable
    {
        string Print(); 
    }
    public class User :IPritable
    {
        public string Print()
        {
            return "user details";
        }
    }
    public class printing
    {
        static void main(string[]args)
        {
            User user = new User();
            Console.WriteLine(user.Print());
        }
    }
}

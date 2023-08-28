using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Person
    {
        protected string name, address;
        protected long aadharno;

        public Person(string name, string address, long aadharno)
        {
            this.name = name;
            this.address = address;
            this.aadharno = aadharno;


        }
    }
    public class Patient:Person
    {
        private string bloodgrup;
        
        public Patient(string bloodgrup, string name,string address,long aadharno) : base(name, address, aadharno)
        {
            this.bloodgrup = bloodgrup;
        }

        public string Display1()
        {
            return$"{bloodgrup} {name} {address} {aadharno}";
        }
    }
}
        
     

        
           
        
       
    


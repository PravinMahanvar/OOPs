using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{

    // default parameter /optional 
    public class Car
    {
        private string companyname, modelname;
        private int cost;

        public Car(string modelname, int cost, string companyname = "tata")
        {
            this.modelname = modelname;
            this.cost = cost;
            this.companyname = companyname;
        }
        public void Accept(string modelname, string companyname = "tata")
        {
            this.modelname = modelname;
            this.companyname = companyname;
        }
        public string Print()
        {
            return $"{modelname} {cost} {companyname}";

        }


    }
}

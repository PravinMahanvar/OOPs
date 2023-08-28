using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // creatd class product contain code,name,& price give 10 % discount on price & display original & discounted price?
    public  class Product
    {
        private int productid;
        private string productname;
        private double price;

        public Product(int productid, string productname, double price)
        {
            this.productid = productid;
            this.productname = productname;
            this.price = price;
        }
        public void Discount(double discountper)
        {
            price = price - (price*(discountper/10));
                
        }
        public string Print()
        {
            return$"productid={productid}\n productname= {productname}\n price{price}";
        }
    }
}

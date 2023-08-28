using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Class1
    {
        private int day, year;
        private string months;

        public void AcceptDate(int dd,string mm, int yy)
        {
            day = dd;
            months = mm;
            year = yy;
        }

        public string PrintClass1()
        {
            return $"Class1 :{day}/ {months}/{year}";

        }

        
            

    }
}

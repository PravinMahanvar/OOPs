using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Movie
    {
        private int mid;
        private string mname;
        private int tprice;
        private int noofticket;
        private string mtype;
        private int want;
        private int totalbill;


        public Movie(int mid, string mname, int tprice, int noofticket)
        {
            this.mid = mid;
            this.mname = mname;
            this.tprice = tprice;
            this.noofticket = noofticket;
        }
        public string printmember()
        {
            return $"{mid} {mname} {tprice} {noofticket}";
        }
        public void Available()
        {
            Console.WriteLine("enter the number of ticket ");
            want = Convert.ToInt32(Console.ReadLine());

            if (noofticket > want)
            {
                int available = noofticket - want;
                this.ticketcost();
            }
            else
            {
                Console.WriteLine("not sufficient ticket");
            }
        }
        public void ticketcost()
        {
            Console.WriteLine("1 silver");
            Console.WriteLine("2 Gold");
            Console.WriteLine("3 platinum");
            Console.WriteLine("enter the type");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    mtype = "silver";
                    tprice = 100;
                    break;
                case 2:
                    mtype = "gold";
                    tprice = 200;
                    break;
                case 3:
                    mtype = "platinum";
                    tprice = 300;
                    break;
            }
            totalbill = want * tprice;
        }
        public string print()
        {
            Console.WriteLine("details of booking ");
            return $"your movie name is {mname} your movie id is{mid} ticket you want{want} your total bill{totalbill}";
        }

    }













    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Bank
    {
        private int Acno;
        private string name;
        private double Balance;


        public Bank(int no, string name, double balance)
        {
            Acno = no;
            this.name = name;
            Balance = balance;
        }
        public void Credit(double creditamt)
        {
            Balance += creditamt;
        }
        public string Debit(double debitamt)
        {
            string msg = "";
            if (Balance >= debitamt)
            {
                Balance = Balance - debitamt;
                msg = "transaction is done";
            }
            else
            {
                msg = "insufficient Balance";
            }
            return msg;
        }
        public string Print()
        {
            return $"Accountno{Acno}\n username{name}\n Available{Balance}";
        }
        

        }
    }


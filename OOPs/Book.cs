using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Book
    {
        private int Bookid, Bookprice;
        private string Bookname, Authorname;

        // construtor
         // assihn to deflaut value // parammeter less constructor
        public Book ()
        {
            Bookid  = 0;
            Bookprice = 0;
            Authorname = "";
            Bookname = "";



        }

        public Book (int id, string name ,string author, int price)
        {
            this.Bookid = id;
            this.Authorname = "";
            this .Bookname = name;  
            this .Bookprice = price;    


          
            
        }

     //   public void AcceptBook(int id, string name,string author,int price)
     //   {
      //      Bookid = id;
       //     Bookprice = price;
        //    Authorname= author; ;
        //    Bookname = name;


        //}
        public string PrintBook()
        {
            return $"{Bookid} {Bookname} {Authorname} {Bookprice}";

        }

    }
}

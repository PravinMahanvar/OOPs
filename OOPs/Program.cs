using OOPs.Inheritance;
using OOPs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {






            //create obbj of class

            //Class1 dataobj1 = new Class1();

            // call to methods

            //dataobj1.AcceptDate(4, "Aug", 2023);

            //string res = dataobj1.PrintClass1();
            //Console.WriteLine(res);

            //Student dataobj2 = new Student();
            // dataobj2.AcceptStudent(100, 65.5, "pravin mahanvar", "mechanical");
            //  string data = dataobj2.PrintStudent();
            //Console.WriteLine(data);

            // Employee dataobj3 = new Employee();
            // dataobj3.Accept(90, "pravin ", 4500);
            // string Emp = dataobj3.Print();

            //  Console.WriteLine(Emp);

            /**   Book dataobj4= new Book();
               dataobj4.AcceptBook(10, "wings of fire", "apj kalam", 500);
               string Book = dataobj4.PrintBook();
                 Console.WriteLine(Book);    **/

            /**  Employee employee= new Employee();
              Employee employee2 = new Employee(12, "pravin mahanvar ", 50000);
              Employee employee3 = new Employee(13, "pramod mahanvar", 70000); **/

            /**   employee2.CalculatedSalary();
               employee3.CalculatedSalary();
               Console.WriteLine(employee2.Print());
               Console.WriteLine(employee3.Print());  **/

            /**   Book book  = new Book(); 
               Book book2 = new Book(10,"wings of fire", "apj kalam ", 800);
               Book book3 = new Book(20, "aaibook", "pravin mahanvar", 90);

               book2.PrintBook();
               book3.PrintBook();  
               Console.WriteLine(book2.PrintBook());   
               Console.WriteLine(book3.PrintBook());  **/

            /**   Bank obj1 = new Bank(9999, "pravin", 5000);
               Console.WriteLine(obj1.Print());
               obj1.Credit(5000);
               Console.WriteLine(obj1.Print());
               string msg = obj1.Debit(666000);
              
               Console.WriteLine(msg);
               Console.WriteLine(obj1.Print()); **/

            /**  Product B = new Product(4555, "sunglass", 500);
              Console.WriteLine(B.Print());
              B.Discount(10);
              Console.WriteLine("price after discount");
              Console.WriteLine(B.Print());

              Employee emp1 = new Employee( 3000,"prvin",899);
              Employee emp2 = new Employee(90,"pravin mahnvar",900);
              Employee emp3 = new Employee(90000,"pramod",90);

              emp1.CalculatedSalary();
              emp2.CalculatedSalary();
              emp3.CalculatedSalary();

              Console.WriteLine(emp1.Print());
              Console.WriteLine(emp2.Print());
              Console.WriteLine(emp3.Print());

              Console.WriteLine("totol" +Employee.GetEmpCount());  **/


            /**    Student2 stud = new Student2();
                stud.Rollno = 1;
                stud.Name = "Pravin";
                stud.percentage = 100;   **/

            //  Console.WriteLine($"{stud.Rollno} {stud.Name} {stud.percentage}");
            // Console.WriteLine(stud.Print());


            /**  Student2 stud2 = new Student2() { Rollno = 2, Name = "Pravin mahanvar", percentage = 90 };
              Console.WriteLine($"{stud2.Rollno} {stud2.Name} {stud2. percentage}");  **/




            /**    Movie m1 = new Movie(800, "msdhoni", 200, 90);
                  Console.WriteLine(m1.printmember());
                  m1.Available();
                  Console.WriteLine(m1.print());  **/


            /**   Calculation c= new Calculation();
                Console.WriteLine(c.Additiondata(10, 23));
                Console.WriteLine(c.Additiondata(12, 12, 12));
                Console.WriteLine(c.Additiondata(12, 12));    **/

            /* Car c1 = new Car("23", 8999999);
             Car c2 = new Car("34", 88980, "hundia");

             Console.WriteLine(c1.Print());
             Console.WriteLine(c2.Print());*/

            /*
                        Manager m1 = new Manager(9000,"pravin",9000);
                        m1.Print();
                        Console.WriteLine(m1.Print());

                        Patient p1 = new Patient("o+", "pravin mahanvar ", "osamanbad",96574);
                        p1.Display1();
                        Console.WriteLine(p1.Display1());*/

            /**//*
                        Employee_Inhi e1 = new Manager(9000, "PARVIN ", 90000);
                        e1.CalculatedSalary();
                        Console.WriteLine(e1.Print());*//*

                        calculate c1 = new calculate(6, 7);
                        Console.WriteLine(c1.Draw("this parent class methoddd"));
                        c1.Area();
                        c1.Displaymethod();*/
            /*
                        User user1 = new User();
                        Console.WriteLine(user1.Print());
            *//*
            Interface2 c1 = new transaction();
            Console.WriteLine(c1.Display());

            Iorders p1 = new transaction();
            Console.WriteLine(p1.Display());*/
            /*
                        Calc p2 = new Calc();
                        Console.WriteLine(p2.Add(90, 90));*/
            /*
                        over1 p1= new over1();8
                        p1.Method1();
                        Derivedclass dc = new Derivedclass();
                        dc.Method1();
                        dc.Method2();

                        over1 p1dc= new Derivedclass();
                        p1dc.Method1();*/

            /*
                        Digitaldevice device= new Digitaldevice();
                        device.ConnectBluetooth();
                        device.ConnectWifi();*/


              







    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{

    //13.	Write a C# program to find total number of alphabets, digits or special character in a string.
    internal class digits_specialnumber
    {
        static void Main(string[] args)
        {
            string sms = "Hii 1all";
            char[] chars = sms.ToCharArray();

            int count1 = 0;
            int count2= 0;
            int count3= 0;
            for(int i= 0; i<chars.Length; i++)
            {
                 if ((chars[i] >= 'a' && chars[i] <= 'z' )|| ((chars[i] <= 'A' && chars[i] <= 'z')))
                 {
                    count1++;

                 }
                 else if((chars[i] >='0' && chars[i]<= '9'))
                 {
                    count2++;
                 }
                else
                {
                    count3++;
                }
                    

                                 
            }
            Console.WriteLine("count of char" + count1);
            Console.WriteLine("count of digit" + count2);
            Console.WriteLine("count of symbols" + count3);

               


        }
    }
}

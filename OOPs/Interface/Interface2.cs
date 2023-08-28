using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface
{
    public  interface Interface2
    {
        string Display();

    }
    public interface Iorders
    {
        string Display();
    }

    public class transaction :Interface2, Iorders
    {
        string Interface2.Display()
        {
            return "customer deatils";
        }
         string Iorders. Display()
        {
            return " Order deatils";
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public interface IWifi
    {
        void ConnectWifi();
    }
    public interface Ibluetoothdevice
    {
        void ConnectBluetooth();
    }
    public class Digitaldevice: IWifi, Ibluetoothdevice
    {
        public void ConnectWifi()
        {
            Console.WriteLine("connected to Wifi");
        }
        public void ConnectBluetooth()
        {
            Console.WriteLine("connected to Bluetooth");
        }
    }
}

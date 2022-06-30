using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            string ipPc, ipDevice, arq;
            Console.WriteLine("Digite o IP do computador!");
             ipPc = Console.ReadLine();
            Console.WriteLine("Digite o IP do Equipamento!");
            ipDevice = Console.ReadLine();
            Console.Write("Digite o nome do arquivo com a extensão: ");
            arq = Console.ReadLine();
            Operation op = new Operation();
            List<string> comando = new List<string>();
            comando.Add("cd /mnt/mtdblock");
            comando.Add("tftp -l " + arq + " -g " + ipPc + " -b 65355 && tar xvzf " + arq + " && rm " + arq);
            comando.Add("reboot");
            Console.WriteLine(op.sendCommand(ipDevice, ipPc, comando));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexãoSsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textIP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void texDeviceIP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameArq_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ssh op = new Ssh();
            string ip = textIP.Text;
            string deviceip = texDeviceIP.Text;
            string arq = nameArq.Text;
            List<string> comando = new List<string>();
            comando.Add("cd /mnt/mtdblock");
            comando.Add("tftp -l " + arq + " -g " + ip + " -b 65355 && tar xvzf " + arq + " && rm " + arq);
            comando.Add("reboot");
            Console.WriteLine(op.sendCommand(deviceip, ip, comando));

        }
    }
}

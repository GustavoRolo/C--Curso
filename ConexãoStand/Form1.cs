using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexãoStand
{
    public partial class Form1 : Form
    {
        zkemkeeper.CZKEMClass zk = new zkemkeeper.CZKEMClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string device_ip = textBox1.Text;
            int device_port = int.Parse(textBox2.Text);

            Boolean connectstatus = zk.Connect_Net(device_ip, device_port);

            if (connectstatus == true)
            {
                MessageBox.Show("Dispositivo Conectado");

            }
            else
            {
                MessageBox.Show("Falha na conexão");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean connectstatus = zk.RestartDevice(1);
            
            if (connectstatus == true)
            {
                MessageBox.Show("Dispositivo Reiniciado");

            }
            else
            {
                MessageBox.Show("Falha ao Reiniciar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zk.ACUnlock(1, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zk.SetStrCardNumber(textBox3.Text);
        }
    }
}

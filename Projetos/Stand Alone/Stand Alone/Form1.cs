using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;




namespace Stand_Alone
{
    public partial class Form1 : Form
    {
        public string deviceip;
        public int deviceport;
        zkemkeeper.CZKEMClass dll = new zkemkeeper.CZKEMClass();

        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            deviceip = textBox1.Text;
            deviceport = int.Parse(textBox2.Text);


            Boolean connectstatus = dll.Connect_Net(deviceip, deviceport);

            if (connectstatus == true)
            {
                MessageBox.Show("Device connect");

            }
            else
            {
                MessageBox.Show("Connect fail");
            }

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public void TextBoxPorttextBox2_TextChanged(object sender, EventArgs a)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dll.RestartDevice(1);
            dll.Disconnect();

            Boolean resettstatus = dll.RestartDevice(1);

            if (resettstatus == true)
            {
                MessageBox.Show("Reset Device");
            }
            else
            {
                MessageBox.Show("Reset Faill");
            }



        }

    }
}
